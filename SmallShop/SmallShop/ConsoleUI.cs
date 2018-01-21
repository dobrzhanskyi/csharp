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

		}

		public void CheckingConsole()
		{
			ShowInstructions();
			var inputCommand = string.Empty;
			while (inputCommand != "exit")
			{
				inputCommand = Console.ReadLine();
				if (!inputCommand.Contains(":"))
				{
					Console.WriteLine("Bad input");
					return;
				}

				string[] split = inputCommand.Split(':');
				string command = split[0];
				if (split.Length < 1)
				{
					Console.WriteLine("Bad Input");
				}

				string inputValues = split[1];
				switch (command)
				{
					//TODO:Parse exception (command)
					case "add":
						operations.AddNewItem(inputValues);
						break;
					case "remove":
						operations.RemoveItem(inputValues);
						break;
					case "display":
						operations.DisplayPriceList();
						break;
					case "take":
						operations.TakeToStock(inputValues);
						break;
					case "displays":
						operations.DisplayStock();
						break;
					case "sell":
						operations.SellFromStock(inputValues);
						break;
					case "sort":
						operations.DisplayGroupedStock();
						break;
					default:
						break;
				}
			}
		}
	}
}
