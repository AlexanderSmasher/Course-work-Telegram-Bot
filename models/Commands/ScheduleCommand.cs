using Telegram.Bot;
using Telegram.Bot.Types;

namespace OSBBBot.models.Commands
{
    public class ScheduleCommand : Command
    {
        public override string[] Names { get; set; } = new string[] { "/schedule", "schedule" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "\tРозклад прийому:\n\nПН: 9:00 - 20:00\nВТ: 9:00 - 20:00\n" +
                "СР: 9:00 - 20:00\nЧТ: 9:00 - 20:00\nПТ: 9:00 - 20:00\nСБ: 10:00 - 18:00\nНД: 10:00 - 16:00");
        }
    }
}
