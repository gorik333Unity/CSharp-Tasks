using System;

namespace Learning
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.StartTiming();

            Thread.Sleep(2000);

            var seconds = stopwatch.StopTiming();

            Console.WriteLine(seconds);

            stopwatch.StartTiming();

            Thread.Sleep(3000);

            seconds = stopwatch.StopTiming();

            Console.WriteLine(seconds);
        }
    }
}