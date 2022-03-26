using System;

namespace WorkflowEngine
{
    public class Operation : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Operation executed...");
        }
    }
}
