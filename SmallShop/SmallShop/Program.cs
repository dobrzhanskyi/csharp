using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallShop
{
	class Program
	{
		static void Main(string[] args)
		{
			var operations = new Operations();
			var consoleUI = new ConsoleUI(operations);
			consoleUI.CheckingConsole();
		}
	}
}
