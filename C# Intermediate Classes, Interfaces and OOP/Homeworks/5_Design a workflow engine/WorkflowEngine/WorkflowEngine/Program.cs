using System;

namespace WorkflowEngine
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var workflow = new Workflow();

            workflow.AddTask(new Occupation());
            workflow.AddTask(new Operation());

            var workflowEngine = new WorkflowEngine();

            workflowEngine.Run(workflow);

            Console.ReadLine();
        }
    }
}
