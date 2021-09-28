using Telegram.Bot;
using Telegram.Bot.Types;

namespace OSBBBot.models.Commands
{
    public class FAQCommand : Command
    {
        public override string[] Names { get; set; } = new string[] { "/faq", "faq" };

        public override async void Execute(Message message, TelegramBotClient client)
        {
            await client.SendTextMessageAsync(message.Chat.Id, "\tF.A.Q - Поширені запитання:\n\nQ: Що таке ОСББ?" +
                "\nA: ОСББ - це об'єднння співласників багатоквартирних будинків О.\nQ: Що ми робимо?" +
                "\nA: Усі наші обов'язки ви можете прочитати тут => https://lawportal.com.ua/osmd-osbb-pravovye-njuansy.html <=." +
                "\nQ: Як зв'язатися з нами?\nA: За контактним номером +380453671008." +
                "\nQ: Чи можу я записатися на прийом?\nA: Так, за допомогою нашого боту та команди /signingup.");
        }
    }
}
