using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace StopWatch
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool done = false;
            List<DateTime> startList = new List<DateTime>();
            List<DateTime> stopList = new List<DateTime>();

            while (!done)
            {
                StopWatch stopWatch = new StopWatch();
                
                // Starts the stopwatch
                Console.WriteLine("\nEnter 'y' to start the stopwatch \n");
                while (Console.ReadKey(false).Key != ConsoleKey.Y)
                {
                    Console.WriteLine("\nEnter 'y' to start the start watch \n");
                }
                // Adds the start time to the list
                DateTime start = stopWatch.Start();
                startList.Add(start);

                // Stops the stopwatch 
                Console.WriteLine("\nEnter 'y' to stop the stopwatch \n");
                while (Console.ReadKey(false).Key != ConsoleKey.Y)
                {
                    Console.WriteLine("\nEnter 'y' to stop the stopwatch \n");
                }

                // Adds the stop time to the list
                DateTime end = stopWatch.End();
                stopList.Add(end);

                // Asks whether to start the stopwatch again
                Console.WriteLine("\nEnter 'y' to stop the stopwatch entirely\n");
                if (Console.ReadKey(false).Key == ConsoleKey.Y)
                {
                    done = true;
                }

                // Adds duration to the list
                TimeSpan[] durationList = startList.Zip(stopList, (sta, sto) => StopWatch.Duration(sto, sta)).ToArray();

                // Asks whether to display the duration
                Console.WriteLine("\nEnter 'y' to display the duration\n");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Write("\nNow display the difference for each round:\n");

                    for (var i = 0; i < durationList.Length; i++)
                    {
                        Console.WriteLine(String.Format($"The {i+1}th duration is: {durationList[i]}"));
                    }
                }
            }
        }
    }
}
