using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using bandenbot.Jobs;
using FluentScheduler;
using Telegram.Bot;

namespace bandenbot
{
    public class Program
    {
        public NLog.Logger _logger;
        public static void Main(string[] args)
        {
            var stop = false;
            var config = Config.GetConfig();
            var bot = GetBot(config);

            bot.OnMessage += Bot_OnMessage;
            bot.OnInlineQuery += Bot_OnInlineQuery;
            bot.OnInlineResultChosen += Bot_OnInlineResultChosen;
            bot.OnCallbackQuery += Bot_OnCallbackQuery;
            bot.OnMessageEdited += Bot_OnMessageEdited;
            bot.OnReceiveError += Bot_OnReceiveError;
            bot.OnReceiveGeneralError += Bot_OnReceiveGeneralError;
            bot.OnUpdate += Bot_OnUpdate;

            bot.StartReceiving();

            while (!stop)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.S && key.Modifiers == ConsoleModifiers.Alt)
                {
                    stop = true;
                }
            }
        }

        private static void Bot_OnMessageEdited(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Bot_OnReceiveError(object sender, Telegram.Bot.Args.ReceiveErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Bot_OnReceiveGeneralError(object sender, Telegram.Bot.Args.ReceiveGeneralErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Bot_OnUpdate(object sender, Telegram.Bot.Args.UpdateEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Bot_OnCallbackQuery(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Bot_OnInlineResultChosen(object sender, Telegram.Bot.Args.ChosenInlineResultEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Bot_OnInlineQuery(object sender, Telegram.Bot.Args.InlineQueryEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            throw new NotImplementedException();
        }

        private static TelegramBotClient GetBot(Config config)
        {
            var bot = new Telegram.Bot.TelegramBotClient(config.Bot.Token);
            var infos = bot.GetMeAsync().Result;
            Console.Title = $"{infos.Username} started at {DateTime.Now}";
            return bot;
        }
    }
}
