using System;

namespace EventDelegate
{
    public class TextService
    {
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.Write("TextService: sending text messages..." + e.Video.Title);
        }
    }
}