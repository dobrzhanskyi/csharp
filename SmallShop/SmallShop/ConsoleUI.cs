using System;

namespace SmallShop
{
	internal class ConsoleUI
	{
		private readonly Operations _operations;

		public ConsoleUI(Operations operations)
		{
			this._operations = operations;
		}

		private void ShowInstructions()
		{
			Console.WriteLine(@"Type ""help:"" for available commands :");
		}

		public void CheckingConsole()
		{
			ShowInstructions();
			_operations.LoadFiles();
			var inputCommand = string.Empty;
			while (true)
			{
				inputCommand = Console.ReadLine();
				if (inputCommand == "exit")
				{
					break;
				}
				if (!inputCommand.Contains(":"))
				{
					_operations.ShowError();
					CheckingConsole();
				}

				string[] split = inputCommand.Split(':');
				string command = split[0];

				if (split.Length < 1)
				{
					_operations.ShowError();
				}

				string inputValues = split[1];
				switch (command)
				{
					case "add":
						_operations.AddNewItem(inputValues);
						break;

					case "remove":
						_operations.RemoveItem(inputValues);
						break;

					case "display":
						_operations.DisplayPriceList();
						break;

					case "take":
						_operations.TakeToStock(inputValues);
						break;

					case "displays":
						_operations.DisplayStock();
						break;

					case "sell":
						_operations.SellFromStock(inputValues);
						break;

					case "close":
						_operations.Exit();
						break;

					case "help":
						_operations.ShowHelp();
						break;

					case "exit":
						Environment.Exit(0);
						break;

					default:
						break;
				}
			}
		}
	}
}