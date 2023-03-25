using System.Text;

namespace ChatServer
{
	// Packet Structure
	// Description       |dataIdentifier|username length|message length|    username   |    message   |
	// Size              |    4 byte    |     4 byte    |    4 byte    |username length|message length|
	public enum DataIdentifier
	{
		Message,
		LogIn,
		LogOut,
		ServerStopped,
		Null
	}

	public class Packet
	{
		#region Public Members
		public DataIdentifier ChatDataIdentifier
		{
			get { return _dataIndentifier; }
			set { _dataIndentifier = value; }
		}

		public string ChatName
		{
			get { return _name; }
			set { _name = value; }
		}

		public string ChatMessage
		{
			get { return _message; }
			set { _message = value; }
		}
		#endregion

		#region Private Members
		private DataIdentifier _dataIndentifier;
		private string _name;
		private string _message;
		#endregion

		#region Constructor
		public Packet()
		{
			_dataIndentifier = DataIdentifier.Null;
			_name = "";
			_message = "";
		}

		public Packet(DataIdentifier dataIdentifier, string message, string name)
		{
			_dataIndentifier = dataIdentifier;
			_name = name;
			_message = message;
		}

		/// <summary>
		/// Decode Datagram
		/// </summary>
		/// <param name="data"></param>
		public Packet(byte[] data)
		{
			_dataIndentifier = (DataIdentifier)BitConverter.ToInt32(data, 0);

			Int32 nameLenght = BitConverter.ToInt32(data, 4);

			Int32 messageLenght = BitConverter.ToInt32(data, 8);

			if (nameLenght > 0)
				_name = Encoding.Unicode.GetString(data, 12, nameLenght);
			else
				_name = "";

			if (messageLenght > 0)
				_message = Encoding.Unicode.GetString(data, 12 + nameLenght, messageLenght);
			else
				_message = "";
		}
		#endregion

		#region Public Methods
		public byte[] GetDatagram()
		{
			List<byte> dataStream = new List<byte>();

			dataStream.AddRange(BitConverter.GetBytes((Int32)_dataIndentifier));

			// String lenght != unicode lenght
			dataStream.AddRange(BitConverter.GetBytes((Int32)Encoding.Unicode.GetByteCount(_name)));

			dataStream.AddRange(BitConverter.GetBytes((Int32)Encoding.Unicode.GetByteCount(_message)));

			if (!string.IsNullOrEmpty(_name))
				dataStream.AddRange(Encoding.Unicode.GetBytes(_name));

			if (!string.IsNullOrEmpty(_message))
				dataStream.AddRange(Encoding.Unicode.GetBytes(_message));

			return dataStream.ToArray();
		}
		#endregion
	}
}