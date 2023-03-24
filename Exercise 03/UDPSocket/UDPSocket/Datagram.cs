namespace UDPSocket
{
	public class Datagram
	{
		/// <summary>
		/// IP address of the Remote Endpoint.
		/// </summary>
		public string Ip { get; }

		/// <summary>
		/// Port number of the Remote Endpoint.
		/// </summary>
		public Int32 Port { get; }

		/// <summary>
		/// Data received from the Remote Endpoint.
		/// </summary>
		public byte[] Data { get; }

		internal Datagram() { }

		internal Datagram(string ip, int port, byte[] data)
		{
			if (String.IsNullOrEmpty(ip)) throw new ArgumentNullException(nameof(ip));
			if (port < 0 || port > 65535) throw new ArgumentException("Port must be greater than or equal to zero and less than or equal to 65535.");

			Ip = ip;
			Port = port;
			Data = data;
		}
	}
}
