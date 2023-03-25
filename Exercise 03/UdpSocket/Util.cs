namespace UdpSocket
{
	public static class Util
	{
		/// <summary>
		/// Parse an IP:port string to its parts.
		/// </summary>
		/// <param name="ipPort">IP:port.</param>
		/// <param name="ip">IP address.</param>
		/// <param name="port">Port number.</param>
		public static void ParseIpPort(string ipPort, out string ip, out int port)
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
