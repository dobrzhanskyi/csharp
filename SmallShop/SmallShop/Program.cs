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
