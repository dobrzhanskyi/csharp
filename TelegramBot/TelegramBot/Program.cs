using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.InlineKeyboardButtons;


namespace TelegramBot
{
	class Program
	{
		static TelegramBotClient Bot;
		static void Main(string[] args)
		{
			Bot = new TelegramBotClient("593986184:AAG--tKPoPzn81lELpe_zD-To0dVBloBvJ4");

			Bot.OnMessage += Bot_OnMessageReceivedAsync;
			Bot.OnCallbackQuery += BotOnCallBackQueryReceived;
			var me = Bot.GetMeAsync().Result;

			Console.WriteLine(me.FirstName);
			Bot.StartReceiving();
			Console.ReadLine();
			Bot.StartReceiving();
		}

		private static void BotOnCallBackQueryReceived(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
		{

		}

		private static async void Bot_OnMessageReceivedAsync(object sender, Telegram.Bot.Args.MessageEventArgs e)
		{
			var message = e.Message;
			if (message.Type != MessageType.TextMessage)
				return;

			string name = $"{message.From.FirstName}{message.From.LastName}";

			Console.WriteLine($"{name} отправил сообщение {message.Text}");

			switch (message.Text)
			{
				case "/start":
					string text =
@"Список команд:
/start - запуск бота
/inline - вывод меню
/keyboard - вывод клавиатуры
";
					await Bot.SendTextMessageAsync(message.From.Id, text);
					break;
				case "/inline":
					var inlineKeyboard = new InlineKeyboardMarkup(new[]
					{
						new[]
						{
							InlineKeyboardButton.WithUrl("Web","http://pornhub.com")
						},
						new[]
						{
							InlineKeyboardButton.WithCallbackData("Punkt 1"),
							InlineKeyboardButton.WithCallbackData("Punkt 2")
						}

					});
					await Bot.SendTextMessageAsync(message.From.Id, "Выберите пункт", replyMarkup: inlineKeyboard);
					break;
				case "/keyboard":
					break;
				default:
					break;
			}
		}
	}
}
