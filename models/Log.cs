using System;

namespace OSBBBot.models
{
    public static class Log
    {
        public static void MessageLog(int type, string typeMess, string message)
        {
            if (type == 0) // INFO
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"[INFO] {typeMess}: {message}.");
            }
            else if(type == 1) // WARNING
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"[WARNING] {typeMess}: {message}!");
            }
            else if(type == 2) // ERROR
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[ERROR] {typeMess}: {message}!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine($"[SYSTEM ERROR] Process have some problems!");
            }
        }
        public static void ClearLog()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
        }
    }
}
