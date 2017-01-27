using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace Logger.Telegram
{
    public class Bot
    {
        private readonly string _channelUserName;
        private TelegramBotClient _bot;
        public Bot(string token, string channelUserName)
        {
            _channelUserName = channelUserName;
            this._bot = new TelegramBotClient(token);
        }

        public async void Send(string message)
        {
            await _bot.SendTextMessageAsync(_channelUserName, message, true, false,0,null,ParseMode.Markdown,default(CancellationToken));
        }
    }
}
