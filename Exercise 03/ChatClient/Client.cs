using ChatServer;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using UdpSocket;

namespace ChatClient
{
	public partial class Client : Form
	{
		#region Private-Member
		private string _username;
		private IPAddress _serverIP;
		private Int32 _serverPort;
		private UdpEndpoint _endpoint;
		private bool _isConnected = false;
		private System.Timers.Timer _timer;

		// Status delegate
		private delegate void DisplayMessageDelegate(string message);
		private DisplayMessageDelegate _displayMessageDelegate = null;
		#endregion

		#region Constructors
		public Client()
		{
			InitializeComponent();
		}
		#endregion

		#region Winform Events
		private void Client_Load(object sender, EventArgs e)
		{
			_displayMessageDelegate = new DisplayMessageDelegate(DisplayMessage);
		}

		private void buttonConnect_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxUsername.Text))
			{
				MessageBox.Show("Vui lòng nhập Tên tài khoản và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxServerPort.Text))
			{
				MessageBox.Show("Vui lòng nhập Port và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (string.IsNullOrEmpty(textBoxServerIP.Text))
			{
				MessageBox.Show("Vui lòng nhập IP và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!IPAddress.TryParse(textBoxServerIP.Text, out _serverIP))
			{
				MessageBox.Show("Địa chỉ IP không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Int32.TryParse(textBoxServerPort.Text, out _serverPort))
			{
				MessageBox.Show("Số port không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (_serverPort < 0 || _serverPort > 65535)
			{
				MessageBox.Show("Số port phải lớn hơn 0 và nhỏ hơn hoặc bằng 65535", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				_serverPort = 0;
				return;
			}
			_endpoint = new UdpEndpoint("127.0.0.1", GetFreeUdpPort());
			_username = textBoxUsername.Text.Trim();
			Packet sendLogin = new Packet();
			sendLogin.ChatDataIdentifier = DataIdentifier.LogIn;
			sendLogin.ChatName = _username;
			sendLogin.ChatMessage = "";

			byte[] loginDatagram = sendLogin.GetDatagram();

			try
			{
				_ = _endpoint.SendAsync(_serverIP.ToString(), _serverPort, loginDatagram);
				_endpoint.Start();
				_timer = new System.Timers.Timer(5000);
				_timer.AutoReset = false;
				_timer.Start();
				_timer.Elapsed += OnTimeOut;
				_endpoint.DatagramReceived += DatagramReceived;
				_endpoint.EndpointDeteched += Connected;
				buttonConnect.Enabled = false;
			}
			catch (Exception ex)
			{
				richTextBoxChatLog.Text = "Lỗi";
				MessageBox.Show("Connection Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonDisconnect_Click(object sender, EventArgs e)
		{
			SendLogout();
			_endpoint.Stop();
			_endpoint = null;
			_isConnected = false;
			buttonConnect.Enabled = true;
			buttonDisconnect.Enabled = false;
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			if (_isConnected)
			{
				SendLogout();
				_endpoint.Stop();
			}
			Close();
		}

		private void buttonSend_Click(object sender, EventArgs e)
		{
			try
			{
				Packet sendData = new Packet();
				sendData.ChatName = _username;
				sendData.ChatMessage = textBoxMessage.Text.Trim();
				sendData.ChatDataIdentifier = DataIdentifier.Message;

				byte[] sendDatagram = sendData.GetDatagram();

				_endpoint.Send(_serverIP.ToString(), _serverPort, sendDatagram);

				textBoxMessage.Text = string.Empty;
				buttonSend.Enabled = false;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Send Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void textBoxMessage_TextChanged(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(textBoxMessage.Text))
			{
				buttonSend.Enabled = false;
			}
			else if (_isConnected)
			{
				buttonSend.Enabled = true;
			}
		}
		#endregion

		#region Events
		private void DatagramReceived(object sender, Datagram receiveDatagram)
		{
			Packet receivedData = new Packet(receiveDatagram.Data);

			if (receivedData.ChatDataIdentifier == DataIdentifier.ServerStopped)
			{
				_isConnected = false;
				_endpoint.Stop();
				_endpoint = null;
				this.Invoke(new MethodInvoker(() => buttonConnect.Enabled = true));
				this.Invoke(new MethodInvoker(() => buttonDisconnect.Enabled = false));
			}

			if (!string.IsNullOrEmpty(receivedData.ChatMessage))
			{
				this.Invoke(_displayMessageDelegate, new object[] { receivedData.ChatMessage });
			}
		}

		private void Connected(object sender, EndpointMetadata metadata)
		{
			if (metadata.Ip == _serverIP.ToString())
			{
				if (!_isConnected)
				{
					_timer.Stop();
					_isConnected = true;
					this.Invoke(new MethodInvoker(() => buttonConnect.Enabled = false));
					this.Invoke(new MethodInvoker(() => buttonDisconnect.Enabled = true));
				}
			}
		}

		private void OnTimeOut(object sender, EventArgs e)
		{
			if (!_isConnected)
			{
				_endpoint.Stop();
				_endpoint = null;
				this.Invoke(new MethodInvoker(() => buttonConnect.Enabled = true));
				MessageBox.Show("Connection Error: TimeOut", "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Private-Method
		private void DisplayMessage(string messge)
		{
			richTextBoxChatLog.Text += messge + Environment.NewLine;
		}


		private void SendLogout()
		{
			try
			{
				if (_isConnected)
				{
					Packet sendData = new Packet();
					sendData.ChatDataIdentifier = DataIdentifier.LogOut;
					sendData.ChatName = _username;
					sendData.ChatMessage = string.Empty;

					byte[] sendDatagram = sendData.GetDatagram();

					_endpoint.Send(_serverIP.ToString(), _serverPort, sendDatagram);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Closing Error: " + ex.Message, "UDP Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private static int GetFreeUdpPort()
		{
			UdpClient udpClient = new UdpClient(0);
			int port = ((IPEndPoint)udpClient.Client.LocalEndPoint).Port;
			udpClient.Close();
			return port;
		}
		#endregion
	}
}