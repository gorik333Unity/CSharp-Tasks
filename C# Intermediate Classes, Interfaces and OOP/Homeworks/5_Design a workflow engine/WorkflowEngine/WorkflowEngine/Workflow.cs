using System;
using System.Collections.Generic;

namespace WorkflowEngine
{
    public class Workflow : IWorkflow
    {
        private readonly List<ITask> _task;

        public Workflow()
        {
            _task = new List<ITask>();
        }

        public void AddTask(ITask task)
        {
            if (!_task.Contains(task))
                _task.Add(task);
        }

        public void RemoveTask(ITask task)
        {
            if (_task.Contains(task))
                _task.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _task;
        }
    }
}
