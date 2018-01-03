using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
	class ConsoleUI
	{
		private MessageList messageList;

		public ConsoleUI(MessageList messageList)
		{
			this.messageList = messageList;
		}

		private void ShowInstruction()
		{
			Console.WriteLine("Commands : sort or display");
			Console.WriteLine("Enter your message:");
		}

		private void Display(List<Message> messages)
		{
			for (int i = 0; i < messages.Count; i++)
				Console.WriteLine($"{i + 1}\tAction @{messages[i].Action}\tMessage: {messages[i].ToString()}");
		}

		public void CheckingConsole()
		{
			ShowInstruction();

			var inputMessage = string.Empty;

			while (inputMessage != "exit")
			{
				inputMessage = Console.ReadLine();
				switch (inputMessage)
				{
					
					case "sort":
						Display(messageList.Sort());
						break;
					case "display":
						Display(messageList.Messages);
						break;
					case "exit":
						break;
					default:
						messageList.AddMessage(inputMessage);
						break;
				}
			}
		}
	}
}
