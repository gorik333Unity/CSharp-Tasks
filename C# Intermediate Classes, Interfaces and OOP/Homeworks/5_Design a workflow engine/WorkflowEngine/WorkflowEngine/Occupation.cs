using System;

namespace WorkflowEngine
{
    public class Occupation : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Occupation executed...");
        }
    }
}
