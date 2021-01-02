using System.Collections.Generic;

namespace Workflow
{
    public class WorkflowEngine
    {
        private readonly List<IActivity> _activities = new List<IActivity>();

        public WorkflowEngine(List<IActivity> activities)
        {
            activities.ForEach(activity => _activities.Add(activity));
        }
        public void Run()
        {
            _activities.ForEach(activity => activity.Execute());
        }
    }
}