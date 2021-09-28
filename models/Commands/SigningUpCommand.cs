using System;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace OSBBBot.models.Commands
{
    public class SigningUpCommand : Command
    {
        private string CurrentUserId;
        private string CurrentUserName;
        public override string[] Names { get; set; } = new string[] { "/signingup", "signingup" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            CurrentUserId = message.Chat.Id.ToString();
            if(message.Chat.Username != null)
            {
                CurrentUserName = "@" + message.Chat.Username;
            }
            else
            {
                CurrentUserName = "unnamed";
            }
            await client.SendTextMessageAsync(message.Chat.Id, $"Ви успішно записалися на прийом! З вами зв'яжутся протягом 10 хвилин для обговорення часу та дати!");
            await client.SendTextMessageAsync(Configuration.AdminID, $"ЗАПИС: Username: {CurrentUserName} | ID: {CurrentUserId}");
            Log.MessageLog(0, "SIGNUP", $"Username: {CurrentUserName} | ID: {CurrentUserId}");
        }
    }
}
