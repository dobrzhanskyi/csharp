using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;
using Telegram.Bot.Types.InlineKeyboardButtons;
using Telegram.Bot.Types;
using ApiAiSDK;
using ApiAiSDK.Model;


namespace TelegramBot
{
	class Program
	{
		static TelegramBotClient Bot;
		static ApiAi apiAi;
		static void Main(string[] args)
		{
			Bot = new TelegramBotClient("593986184:AAG--tKPoPzn81lELpe_zD-To0dVBloBvJ4");
			AIConfiguration config = new AIConfiguration("65b5cc50b74a4d4b837b24e753a7a17d", SupportedLanguage.Russian);
			apiAi = new ApiAi(config);
			

			Bot.OnMessage += Bot_OnMessageReceivedAsync;
			Bot.OnCallbackQuery += BotOnCallBackQueryReceived;
			var me = Bot.GetMeAsync().Result;

			Console.WriteLine(me.FirstName);
			Bot.StartReceiving();
			Console.ReadLine();
			Bot.StartReceiving();
		}

		private static async void BotOnCallBackQueryReceived(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
		{
			string buttonText = e.CallbackQuery.Data;
			string name = $"{e.CallbackQuery.From.FirstName}{e.CallbackQuery.From.LastName}";
			Console.WriteLine($"{name} нажал кнопку {buttonText}");

			await Bot.AnswerCallbackQueryAsync(e.CallbackQuery.Id, $"Вы нажали кнопку {buttonText}");
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
							InlineKeyboardButton.WithUrl("WebSearch","http://google.com"),
							InlineKeyboardButton.WithUrl("Facebook","http://fb.com")
						},
						new[]
						{
							InlineKeyboardButton.WithCallbackData("Punkt 1"),
							InlineKeyboardButton.WithCallbackData("Punkt 2")
						}

					});
					await Bot.SendTextMessageAsync(message.From.Id, "Выберите пункт меню", replyMarkup: inlineKeyboard);
					break;
				case "/keyboard":
					var replyKeyboard = new ReplyKeyboardMarkup(new[]
			{
					new[]
					{
						new KeyboardButton("Hello"),
				  	new KeyboardButton("How are you?")
					},
					 new[]
					{
			    	new KeyboardButton("Contacts"){ RequestContact=true},
				    new KeyboardButton("GeoLocation"){RequestLocation=true}
					}
			});
					await Bot.SendTextMessageAsync(message.Chat.Id, "Message", replyMarkup: replyKeyboard);
					break;
				default:
					var response = apiAi.TextRequest(message.Text);
					string answer = response.Result.Fulfillment.Speech;
					if (answer == "")
						answer = "Прости, я тебя не понял";
					await Bot.SendTextMessageAsync(message.From.Id, answer);
					break;
			}
		}
	}
}


