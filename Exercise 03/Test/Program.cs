using UdpSocket;
using System;
using System.Text;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			UdpEndpoint udpEndpoint = new UdpEndpoint("", 1000);
			string a = "1";
			udpEndpoint.Send("127.0.0.1", 19132, Encoding.Unicode.GetBytes(a));
			Console.ReadKey();
		}
	}
}

