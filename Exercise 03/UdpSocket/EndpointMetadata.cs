namespace UdpSocket
{
	/// <summary>
	/// Remote Endpoint Metadata
	/// </summary>
	public class EndpointMetadata
	{
		/// <summary>
		/// Ip address of the Remote Endpoint
		/// </summary>
		public string Ip { get; }
		/// <summary>
		/// Port number of Remote Endpoint
		/// </summary>
		public Int32 Port { get; }

		internal EndpointMetadata() { }

		internal EndpointMetadata(string ip, Int32 port)
		{
			if (String.IsNullOrEmpty(ip)) throw new ArgumentNullException(nameof(ip));
			if (port < 0 || port > 65535) throw new ArgumentException("Port must be greater than or equal to zero and less than or equal to 65535.");
			Ip = ip;
			Port = port;
		}
	}
}
