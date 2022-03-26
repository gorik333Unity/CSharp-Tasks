﻿using System.Collections.Generic;

namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void AddTask(ITask task);

        void RemoveTask(ITask task);

        IEnumerable<ITask> GetTasks();
    }
}
