using System;
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
			using (StreamWriter stream = new StreamWriter(@"message.ms"))
			{
				for (int i = 0; i < Messages.Count; i++)
				{
					stream.WriteLine(messages[i].FileSavingFormat());
				}
			}
		}

		public void LoadFile(string path)
		{

			using (StreamReader stream = new StreamReader(path))
			{
				while (!stream.EndOfStream)
				{
					string StringToSplit = stream.ReadLine();
					string[] split = StringToSplit.Split('|');
					string action = split[1];
					string message = split[2];
					string date = split[0];
					DateTime dateTime = DateTime.Parse(date);
					if (!String.IsNullOrEmpty(action))
					{
						action = "@" + action;
					}

					Messages.Add(new Message(message, dateTime, action));
				}
			}
		}

		private void createNewMessage(string message, string action = "")
		{
			Messages.Add(new Message(message, action));
		}

		public void AddMessage(string inputMessage)
		{
			if (string.IsNullOrEmpty(inputMessage))
			{
				return;
			}

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
			else
			{
				createNewMessage(inputMessage);
			}
		}
	}
}
