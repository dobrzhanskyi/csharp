using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
	class ConsoleUI
	{
		private Operations operations;

		public ConsoleUI(Operations operations)
		{
			this.operations = operations;
		}

		private void ShowInstructions()
		{
			Console.WriteLine("Avaliable commands :");
			Console.ReadLine();
		}
		public void CheckingConsole()
		{
			ShowInstructions();
			var inputMessage = string.Empty;

			while (inputMessage != "exit")
			{
				inputMessage = Console.ReadLine();
				string[] split = inputMessage.Split(':');
				string action = split[0];
				switch (action)
				{

					case "add":
				// TODO:		operations.AddItem();
						break;
					case "display":

						break;
					case "exit":
						break;
					case "save":

						break;
					case "load":

						break;
					default:

						break;
				}
			}
		}

	}
}
