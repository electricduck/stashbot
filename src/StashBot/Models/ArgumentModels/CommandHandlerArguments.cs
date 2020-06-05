using Telegram.Bot;
using Telegram.Bot.Args;

namespace StashBot.Models.ArgumentModels
{
    public class CommandHandlerArguments
    {
        public ITelegramBotClient Bot { get; set; }
        public string Command { get; set; }
        public string[] CommandArguments { get; set; }
        public CallbackQueryEventArgs TelegramCallbackQueryEvent { get; set; }
        public MessageEventArgs TelegramMessageEvent { get; set; }
        public TelegramUser TelegramUser { get; set; }
    }
}