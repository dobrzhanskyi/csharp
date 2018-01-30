﻿using System;

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
			Console.WriteLine("Type help for available commands :");
		}
		public void CheckingConsole()
		{
			operations.LoadFiles();
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
					case "close":
						operations.Exit();
						break;
					default:
						break;
				}
			}
		}
	}
}
