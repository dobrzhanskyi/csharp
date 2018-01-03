using System;

namespace ConsoleApp4
{
	public class Message
	{

		readonly public DateTime Date=DateTime.Now;

		public string TextMessage { get; set; }

		public Message(string TextMessage)
		{

			this.TextMessage = TextMessage;
		}

		public override string ToString()
		{
			return $"{Date}\t{TextMessage}";
		}
	}
}
