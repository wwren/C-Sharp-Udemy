using System;
using System.Threading;

namespace EventDelegate
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // To publish an event
        // 1. Define a delegate -> contract/agreement btw publisher & subscriber
        // 2. Define an event based on that delegate 
        // 3. Raise the event
       /* public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); //define a delegate -> just a reference pointing to method that looks like this*/
        // no need to create a customise delegate
        // EventHandler
        // EventHandler<TEventArgs>

        /*public event VideoEncodedEventHandler VideoEncoded; //event based on that delegate // event is fired after VideoEncode has finished*/
        public event EventHandler<VideoEventArgs> VideoEncoded; //pass in variable of type VideoEventArgs
         
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video) //(method) raise an event // to notify subscribers
        // also to pass data about the event that has happened
        {
            if (VideoEncoded != null)  // checking if any subscribers to this event
            {
                VideoEncoded(this, new VideoEventArgs(){Video = video}); //know to make a method call; 'this' is publishing the event; 
            }
        }
    }
}