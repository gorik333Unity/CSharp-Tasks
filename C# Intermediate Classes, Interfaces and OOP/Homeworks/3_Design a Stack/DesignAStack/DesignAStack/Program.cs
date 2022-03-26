using System;

namespace DesignAStack
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var stack = new Stack();

            int numberOfRepetitions = 3;

            for (int i = 0; i < numberOfRepetitions; i++)
                stack.Push(i);

            for (int i = 0; i < numberOfRepetitions; i++)
                Console.WriteLine(stack.Pop());
        }
    }
}
