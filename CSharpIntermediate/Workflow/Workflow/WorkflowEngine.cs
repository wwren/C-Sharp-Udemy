using System.Collections.Generic;
using System;

namespace Workflow
{
    public interface IWorkflow
    {
        void Add(IActivity activity);
        void Remove(IActivity activity);
        List<IActivity> GetActivity();
    }

    public class Workflow : IWorkflow
    {
        private  readonly List<IActivity> _workflow = new List<IActivity>();

        public void Add(IActivity activity)
        {
            _workflow.Add(activity);
        }

        public void Remove(IActivity activity)
        {
            _workflow.Remove(activity);
        }

        public  List<IActivity> GetActivity()
        {
            return _workflow; //return a readonly list
        }
    }

    public class WorkflowEngine
    {

        public void Run(Workflow workflow)
        {
            workflow.GetActivity().ForEach(activity => activity.Execute());
        }
    }
}