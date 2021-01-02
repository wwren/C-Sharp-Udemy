using System.Collections.Generic;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IActivity> workflow = new List<IActivity>();
            workflow.Add(new UploadVideo("uploading a video to a cloud storage"));
            workflow.Add(new CallServer("calling a web service"));
            workflow.Add(new SendEmail("sending an email to the video-owner"));

            WorkflowEngine workflowEngine = new WorkflowEngine(workflow);
            workflowEngine.Run();
        }
    }
}
