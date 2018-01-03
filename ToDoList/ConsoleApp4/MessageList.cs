using System;
using System.Collections.Generic;
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

		string action;

		public void Split(string inputmessage)
		{
			string delimStr = "@ ";
			char[] delimiter = delimStr.ToCharArray();
			string word = inputmessage;
			string[] split = null;
			for (int i = 0; i < inputmessage.Length; i++)
			{
				split = word.Split(delimiter, 5);
			}
			action = split[1];
		}

		public void AddMessage(string inputMessage)
		{

			if (inputMessage.Contains<char>('@'))
			{
				Split(inputMessage);
				Messages.Add(new Message(inputMessage)
				{
					Action = action,
					TextMessage = inputMessage.Substring(action.Length + 2)
				}
				);
			}
			else if (!string.IsNullOrEmpty(inputMessage))
				Messages.Add(new Message(inputMessage));
		}
	}
}
