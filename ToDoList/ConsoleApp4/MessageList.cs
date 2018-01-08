using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp4
{
	public class MessageList
	{
		public List<Message> Messages = new List<Message>();

		public List<Message> Sort()
		{
			return Messages.OrderByDescending(m => m.Date).ToList();
		}

		public void SaveToFile(List<Message> messages)
		{
			using (StreamWriter streamWriter = new StreamWriter(@"message.ms"))
			{
				for (int i = 0; i < Messages.Count; i++)
				{
					streamWriter.WriteLine(messages[i].FileSavingFormat());
				}
			}
		}

		private void createNewMessage(string message, string action = "")
		{
			Messages.Add(new Message(message, action));
		}

		public void AddMessage(string inputMessage)
		{
			if (inputMessage.First().Equals('@'))
			{
				int spaceIndex = inputMessage.IndexOf(' ');
				if (spaceIndex < 0)
				{
					createNewMessage("", inputMessage);
				}
				else
				{
					string action = inputMessage.Substring(0, spaceIndex);
					string text = inputMessage.Substring(spaceIndex + 1);
					createNewMessage(text, action);
				}
			}
			else if (!string.IsNullOrEmpty(inputMessage))
			{
				createNewMessage(inputMessage);
			}
		}
	}
}
