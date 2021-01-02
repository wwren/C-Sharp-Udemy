using System;

namespace StopWatch
{
 
        public class StopWatch
        {
            public DateTime Start()
            {
                return DateTime.Now;
            }

            public DateTime End()
            {
                return DateTime.Now;
            }

            public static TimeSpan Duration(DateTime end, DateTime start)
            {
                TimeSpan timeSpan = end - start;

                if (end < start)
                {
                    throw new InvalidOperationException();
                }
                return timeSpan;
            }
        }
    
}