using System;

namespace WorkflowEngine
{
    public class Plan : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Plan executed...");
        }
    }
}
