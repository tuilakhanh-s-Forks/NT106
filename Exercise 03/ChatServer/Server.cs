using UdpSocket;

namespace ChatServer
{
	public partial class Server : Form
	{
		#region Private Members
		private UdpEndpoint _endpoint;
		private UdpEvents _event;
		private bool _isStarted = false;

		// Status delegate
		private delegate void UpdateStatusDelegate(string status);
		private UpdateStatusDelegate _updateStatusDelegate;
		#endregion

		#region Constructor
		public Server()
		{
			InitializeComponent();
		}
		#endregion

		#region Winform Event
		private void buttonStart_Click(object sender, EventArgs e)
		{
			richTextBoxStatus.Text = "";
			Int32 portNumber;
			if (string.IsNullOrEmpty(textBoxPort.Text))
			{
				MessageBox.Show("Vui lòng nhập Port và thử lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (!Int32.TryParse(textBoxPort.Text, out portNumber))
			{
				MessageBox.Show("Số port không hợp lệ vui lòng nhập lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (portNumber < 0 || portNumber > 65535)
			{
				MessageBox.Show("Số port phải lớn hơn 0 và nhỏ hơn hoặc bằng 65535", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			_endpoint = new UdpEndpoint("", portNumber);
			try
			{
				_endpoint.Start();
				_updateStatusDelegate = new UpdateStatusDelegate(this.UpdateStatus);
				this?.Invoke(_updateStatusDelegate, new object[] { $"Đang nghe tại port {portNumber}" });
				buttonStop.Enabled = true;
				buttonStart.Enabled = false;
				_endpoint.DatagramReceived += DatagramReceived;
				_isStarted = true;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Load Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			SendStoped();
			_endpoint.Stop();
			_endpoint = null;
			_isStarted= false;
			buttonStop.Enabled = false;
			buttonStart.Enabled = true;
			this.Invoke(_updateStatusDelegate, new object[] { "Server Stoped" });
		}

		private void Exit_Click(object sender, EventArgs e)
		{
			if (_isStarted)
			{
				SendStoped();
				_endpoint.Stop();
			}
			Close();
		}
		#endregion

		#region Private Methods
		private void SendStoped()
		{
			try
			{
				Packet sendData = new Packet();
				sendData.ChatDataIdentifier = DataIdentifier.ServerStopped;
				sendData.ChatName = string.Empty;
				sendData.ChatMessage = "Server Stopped";

				byte[] sendDatagram = sendData.GetDatagram();

				foreach (var ipPort in _endpoint.Endpoints)
				{
					string sendIp;
					Int32 sendPort;
					Util.ParseIpPort(ipPort, out sendIp, out sendPort);
					_endpoint.Send(sendIp, sendPort, sendDatagram);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Send Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void DatagramReceived(object sender, Datagram receiveDatagram)
		{
			try
			{
				Packet receivedData = new Packet(receiveDatagram.Data);

				Packet sendData = new Packet();

				sendData.ChatDataIdentifier = receivedData.ChatDataIdentifier;
				sendData.ChatName = receivedData.ChatName;

				switch (receivedData.ChatDataIdentifier)
				{
					case DataIdentifier.Message:
						sendData.ChatMessage = $"{receivedData.ChatName} => {receivedData.ChatMessage}";
						break;
					case DataIdentifier.LogIn:
						sendData.ChatMessage = $"-- {receivedData.ChatName} vừa tham gia vào phòng chat --";
						break;
					case DataIdentifier.LogOut:
						string ipPort = $"{receiveDatagram.Ip}:{receiveDatagram.Port}";
						_endpoint.Endpoints.Remove(ipPort);
						sendData.ChatMessage = $"-- {receivedData.ChatName} vừa thoát khỏi phòng chat --";
						break;
				}

				byte[] sendDatagram = sendData.GetDatagram();

				foreach (var ipPort in _endpoint.Endpoints)
				{
					string sendIp;
					Int32 sendPort;
					Util.ParseIpPort(ipPort, out sendIp, out sendPort);
					_ = _endpoint.SendAsync(sendIp, sendPort, sendDatagram);
				}

				this.Invoke(_updateStatusDelegate, new object[] { $"{receiveDatagram.Ip}:{receiveDatagram.Port} {sendData.ChatMessage}" });
			}
			catch (Exception ex)
			{
				MessageBox.Show("Send Error: " + ex.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void UpdateStatus(string status)
		{
			richTextBoxStatus.Text += status + Environment.NewLine;
		}
		#endregion
	}
}