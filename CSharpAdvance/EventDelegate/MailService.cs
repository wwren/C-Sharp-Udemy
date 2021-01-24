using System;

namespace EventDelegate
{
    public class MailService
    {
        public void onVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MailService: sending an email..." + e.Video.Title);
        }
    }
}