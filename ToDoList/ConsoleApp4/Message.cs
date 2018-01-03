using System;

namespace ConsoleApp4
{
	public class Message
	{
		public Message(DateTime Date, string TextMessage)
		{
			this.Date = Date;
			this.TextMessage = TextMessage;
		}

		readonly public DateTime Date;

		public string TextMessage { get; set; }

		public override string ToString()
		{
			return $"{Date}\t{TextMessage}";
		}
	}
}
