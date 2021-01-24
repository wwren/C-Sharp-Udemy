using System.Reflection;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() {Title = "Video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); // subscriber
            var textService = new TextService(); // another subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; // add mailService as the subscriber to the event OR register a handler to that event
            //behind the scene VideoEncoded is a list of pointers 
            videoEncoder.VideoEncoded += textService.OnVideoEncoded;
            videoEncoder.Encode(video);
           
        }
    }
}
