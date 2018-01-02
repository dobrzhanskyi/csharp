using System;

namespace ConsoleApp4
{
	public class Message
	{
		public DateTime Date { get; set; }
		public string TextMessage { get; set; }

		public override string ToString()
		{
			return $"{Date}\t{TextMessage}";
		}
	}
}
