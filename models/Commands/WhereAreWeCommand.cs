using System.IO;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace OSBBBot.models.Commands
{
    public class WhereAreWeCommand : Command
    {
        private float XPos = (float)50.916716;
        private float YPos = (float)34.811762;
        public override string[] Names { get; set; } = new string[] { "/wherearewe", "wherearewe" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            var fPath = Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\..\resources\location.JPG");
            try
            {
                using (var stream = System.IO.File.Open(fPath, FileMode.Open))
                {
                    var rep = await client.SendPhotoAsync(message.Chat.Id, stream, "Ми знаходимося:\n\n вулиця Новоместеньская 1/2, Суми, Сумська область, 40000");
                }
                Log.MessageLog(0, "PHOTO", "Photo have loaded successfully");
            }
            catch
            {
                Log.MessageLog(2, "PHOTO", "Photo haven`t loaded");
            }
            await client.SendLocationAsync(message.Chat.Id, XPos, YPos);
        }
    }
}
