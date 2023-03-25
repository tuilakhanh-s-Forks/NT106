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
		Null
	}

	public class Packet
	{
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

		private DataIdentifier _dataIndentifier;
		private string _name;
		private string _message;


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

		public byte[] GetDatagram()
		{
			List<byte> dataStream = new List<byte>();

			dataStream.AddRange(BitConverter.GetBytes((Int32)_dataIndentifier));

			dataStream.AddRange(BitConverter.GetBytes((Int32)_name.Length));

			dataStream.AddRange(BitConverter.GetBytes((Int32)_message.Length));

			if (!string.IsNullOrEmpty(_name))
				dataStream.AddRange(Encoding.Unicode.GetBytes(_name));

			if (!string.IsNullOrEmpty(_message))
				dataStream.AddRange(Encoding.Unicode.GetBytes(_message));

			return dataStream.ToArray();
		}

	}
}
