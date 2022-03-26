using System;

namespace WorkflowEngine
{
    public class WorkflowEngine
    {
        public void Run(IWorkflow workflow)
        {
            foreach (var workflowable in workflow.GetTasks())
                workflowable.Execute();
        }
    }
}
