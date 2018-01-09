using System;

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

		public Message(string textMessage, DateTime date, string action = ""):this(textMessage,action)
		{
			this.Date = date;
		}

		public override string ToString()
		{
			return $"{Date}\tMessage: '{Text}'\tAction: '{Action}'";
		}

		public string FileSavingFormat()
		{
			if (Action == String.Empty)
			{
				return $"{Date}|{Action}|{Text}";
			}
			else
			{
				return $"{Date}|{Action.Substring(1)}|{Text}";
			}
		}
	}
}
