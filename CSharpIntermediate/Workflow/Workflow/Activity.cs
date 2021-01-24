using System;

namespace Workflow
{
    public abstract class Activity : IActivity
    {
        public readonly string activity;

        public Activity(string activity)
        {
            this.activity = activity;
        }
        public void Execute()
        {
            Console.WriteLine(String.Format($"In the process of {activity}"));
        }
    }
}