namespace UdpSocket
{
	public class UdpEvents
	{
		/// <summary>
		/// Event when listener has started
		/// </summary>
		public EventHandler Started;

		/// <summary>
		/// Even when listener has stopped
		/// </summary>
		public EventHandler Stopped;

		public UdpEvents() { }

		internal void ListenerStarted(object sender) 
		{ 
			Started?.Invoke(sender, EventArgs.Empty);
		}

		internal void ListenerStopped(object sender)
		{
			Stopped?.Invoke(sender, EventArgs.Empty);
		}
	}
}
