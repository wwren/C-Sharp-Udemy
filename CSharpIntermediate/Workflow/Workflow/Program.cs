using System.Collections.Generic;
using System;

namespace Workflow
{
    class Program
    {
        static void Main(string[] args)
        {
            Workflow workflow = new Workflow();

            workflow.Add(new UploadVideo("uploading a video to a cloud storage"));
            workflow.Add(new CallServer("calling a web service"));
            workflow.Add(new SendEmail("sending an email to the video-owner"));

            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.Run(workflow);
        }
    }
}
