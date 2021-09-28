using Telegram.Bot;
using Telegram.Bot.Types;

namespace OSBBBot.models.Commands
{
    public abstract class Command
    {
        public abstract string[] Names { get; set; }
        public abstract void Execute(Message message, TelegramBotClient client);
        public bool Contains(string message)
        {
            foreach(var key in Names)
            {
                if(message.Contains(key))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
