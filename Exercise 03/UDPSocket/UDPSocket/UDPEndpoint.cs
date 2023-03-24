using System.Net;
using System.Net.Sockets;
using System.Text;

namespace UDPSocket
{
	internal class UDPEndpoint
	{
		/// <summary>
		/// Event when a new endpoint is detected.
		/// </summary>
		public event EventHandler<EndpointMetadata> EndpointDeteched;

		/// <summary>
		/// Event when a datagram is received.
		/// </summary>
		public event EventHandler<Datagram> DatagramReceived;

		/// <summary>
		/// Event
		/// </summary>
		public Events Events
		{
			get { return _Events; }
			set 
			{
				if (value == null) throw new ArgumentNullException(nameof(Events));
				_Events = value;
			}
		}

		/// <summary>
		/// Maximum datagram size, must be greater than zero and less than or equal to 65507.
		/// </summary>
		public int MaxDatagramSize
		{
			get
			{
				return _MaxDatagramSize;
			}
			set
			{
				if (value < 1 || value > 65507) throw new ArgumentException("MaxDatagramSize must be greater than zero and less than or equal to 65507.");
				_MaxDatagramSize = value;
			}
		}

		/// <summary>
		/// Retrun list of seen endpoint
		/// </summary>
		public List<string> Endpoints
		{
			get
			{
				return _RemoteIpPort;
			}
		}

		private IPAddress _IPAddress;
		private Int32 _Port = 0;
		private Socket? _Socket = null;
		private int _MaxDatagramSize = 65507;
		private EndPoint _Endpoint = new IPEndPoint(IPAddress.Any, 0);
		private UdpClient _UdpClient;
		private Events _Events = new Events();

		private List<string> _RemoteIpPort = new List<string>();

		private SemaphoreSlim _SendLock = new SemaphoreSlim(1, 1);
		internal class State
		{
			internal State(int bufferSize)
			{
				Buffer = new byte[bufferSize];
			}

			internal byte[] Buffer;
		}

		/// <summary>
		/// Instantiate the UDP endpoint.
		/// </summary>
		/// <param name="ip">Local IP address.</param>
		/// <param name="port">Local port number.</param>
		public UDPEndpoint(string ip, int port)
		{
			if (string.IsNullOrEmpty(ip)) throw new ArgumentNullException(nameof(ip));
			if (port < 0 || port > 65535) throw new ArgumentException("Port must be greater than or equal to zero and less than or equal to 65535.");
			_Port = port;
			_IPAddress = IPAddress.Parse(ip);

			_UdpClient = new UdpClient();
		}

		/// <summary>
		/// Start the UDP listener to receive datagrams.  Before calling this method, set the 'DatagramReceived' event.
		/// </summary>
		public void Start()
		{
			State state = new State(_MaxDatagramSize);
			_Socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
			_Socket.SetSocketOption(SocketOptionLevel.IP, SocketOptionName.ReuseAddress, true);
			_Socket.Bind(new IPEndPoint(_IPAddress, _Port));

			_Events.ListenerStarted(this);

			_Socket.BeginReceiveFrom(state.Buffer, 0, _MaxDatagramSize, SocketFlags.None, ref _Endpoint, ReciveCallBack, state);
		}

		/// <summary>
		/// Stop the UDP listener.
		/// </summary>
		public void Stop()
		{
			if (_Socket != null)
			{
				_Socket.Close();
			}
		}

		/// <summary>
		/// Send a datagram to the specific IP address and UDP port.
		/// This will throw a SocketException if the report UDP port is unreachable.
		/// </summary>
		/// <param name="ip">IP address.</param>
		/// <param name="port">Port.</param>
		/// <param name="text">Text to send.</param>
		public void Send(string ip, int port, string text)
		{
			if (String.IsNullOrEmpty(ip)) throw new ArgumentNullException(nameof(ip));
			if (port < 0 || port > 65535) throw new ArgumentException("Port is out of range; must be greater than or equal to zero and less than or equal to 65535.");
			if (String.IsNullOrEmpty(text)) throw new ArgumentNullException(nameof(text));
			byte[] data = Encoding.Unicode.GetBytes(text);
			if (data.Length > _MaxDatagramSize) throw new ArgumentException("Data exceed maximum datagram size (" + data.Length + " data bytes, " + _MaxDatagramSize + " bytes).");
			SendInternal(ip, port, data);
		}

		private void ReciveCallBack(IAsyncResult ar)
		{
			try
			{
				State state = (State)ar.AsyncState;
				_Socket.BeginReceiveFrom(state.Buffer, 0, _MaxDatagramSize, SocketFlags.None, ref _Endpoint, ReciveCallBack, state);
				int datagramLenght = _Socket.EndReceiveFrom(ar, ref _Endpoint);

				string ipPort = _Endpoint.ToString();
				string ip;
				Int32 port;
				ParseIpPort(ipPort, out ip, out port);

				if (!_RemoteIpPort.Contains(ipPort))
				{
					_RemoteIpPort.Append(ipPort);
					EndpointDeteched?.Invoke(this, new EndpointMetadata(ip, port));
				}

				if (datagramLenght == state.Buffer.Length)
				{
					// When recived datagram lenght equal to MaxDatagramSize
					DatagramReceived?.Invoke(this, new Datagram(ip, port, state.Buffer));
				}
				else
				{
					// When recived datagram lenght equal to MaxDatagramSize
					byte[] buffer = new byte[datagramLenght];
					Buffer.BlockCopy(state.Buffer, 0, buffer, 0, datagramLenght);
					DatagramReceived?.Invoke(this, new Datagram(ip, port, buffer));
				}
			}
			catch (Exception)
			{
				_Events.ListenerStarted(this);
			}
		}

		private void SendInternal(string ip, int port, byte[] data)
		{
			_SendLock.Wait();

			IPEndPoint ipe = new IPEndPoint(IPAddress.Parse(ip), port);

			try
			{
				_UdpClient.Send(data, data.Length, ipe);
			}
			finally
			{
				_SendLock.Release();
			}
		}

		private static void ParseIpPort(string ipPort, out string ip, out Int32 port)
		{
			if (String.IsNullOrEmpty(ipPort)) throw new ArgumentNullException(nameof(ipPort));

			ip = "";
			port = -1;

			int colonIndex = ipPort.LastIndexOf(':');
			if (colonIndex != -1)
			{
				ip = ipPort.Substring(0, colonIndex);
				port = Convert.ToInt32(ipPort.Substring(colonIndex + 1));
			}
		}
	}
}
