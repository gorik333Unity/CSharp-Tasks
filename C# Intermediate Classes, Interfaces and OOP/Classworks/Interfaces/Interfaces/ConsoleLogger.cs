using System;

namespace Interfaces
{
    public class ConsoleLogger : ILogger
    {
        public void LogInfo(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(message);
        }

        public void LogError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(message);
        }
    }
}
