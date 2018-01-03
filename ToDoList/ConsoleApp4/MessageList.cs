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

		public void AddMessage(string inputMessage)
		{
			if (!string.IsNullOrEmpty(inputMessage))
				Messages.Add(new Message(DateTime.Now, inputMessage));
		}
	}
}
