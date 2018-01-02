namespace ConsoleApp4
{
	class Program
	{
		static void Main(string[] args)
		{
			var messageList = new MessageList();
			var consoleUI = new ConsoleUI(messageList);
			consoleUI.CheckingConsole();
		}
	}
}
