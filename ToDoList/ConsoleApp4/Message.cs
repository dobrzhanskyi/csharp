using System;

// Save format: {Date}{Action}{Text}    
//                      |без собаки
// Каждое сообщение с новой строки.
// *.ms расширение
// StreamWriter почитать, using 

namespace ConsoleApp4
{
	public class Message
	{
		readonly public DateTime Date = DateTime.Now;

		public string Action { get; set; }

		public string Text { get; set; }

		public Message(string textMessage, string action = "")
		{
			this.Action = action;
			this.Text = textMessage;
		}

		public override string ToString()
		{
			return $"{Date}\tMessage: '{Text}'\tAction: '{Action}'";
		}

		public string FileSavingFormat()
		{
			if (Action == String.Empty)
			{
				return $"{Date}\tAction: '{Action}'\tMessage: '{Text}'";
			}
			else
			{
				return $"{Date}\tAction: '{Action.Substring(1)}'\tMessage: '{Text}'";
			}
		}
	}
}
