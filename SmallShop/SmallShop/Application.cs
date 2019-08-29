namespace SmallShop
{
	internal class Application
	{
		private static void Main()
		{
			var _operations = new Operations();
			var _consoleUI = new ConsoleUI(_operations);
			_consoleUI.CheckingConsole();
		}
	}
}