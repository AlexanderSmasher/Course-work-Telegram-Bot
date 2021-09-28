using OSBBBot.models;
using OSBBBot.models.Commands;
using System;
using System.Collections.Generic;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace OSBBBot
{
    class Run
    {
        private static TelegramBotClient Client;
        private static List<Command> commands;

        static void Main(string[] args)
        {
            Log.ClearLog();
            BotProcessing();
        }

        private static void BotProcessing()
        {
            try
            {
                Client = new TelegramBotClient(Configuration.Token);

                commands = new List<Command>();
                commands.Add(new ScheduleCommand());
                commands.Add(new FAQCommand());
                commands.Add(new WhereAreWeCommand());
                commands.Add(new SigningUpCommand());

                Client.StartReceiving();
                Log.MessageLog(0, "RUN", "Bot start successfully");
            }
            catch
            {
                Log.MessageLog(2, "RUN", "Bot haven`t started");
                Client.StopReceiving();
            }
            Client.OnMessage += OnMessageHandler;
            Console.ReadKey();
            Client.StopReceiving();
        }

        private static void OnMessageHandler(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if(message.Text != null)
            {
                Log.MessageLog(0, "MESSAGE", $"New message! From: {message.From.FirstName} {message.From.LastName} Text: {message.Text}");
                foreach(var key in commands)
                {
                    if (key.Contains(message.Text))
                    {
                        key.Execute(message, Client);
                    }
                }
            }
        }
    }
}
