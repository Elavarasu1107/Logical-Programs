using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class StopWatch
    {
        public void TimeElapsed()
        {
            Stopwatch timer = new Stopwatch();
            Console.WriteLine("Type 'start' to Start the timer or 'stop' to Stop the timer");
            for (int i = 1; i <= 2;)
            {
                var userInput = Console.ReadLine();
                var finalInput = userInput.ToLower();

                if (finalInput == "start")
                {
                    if (i == 1)
                    {
                        Console.WriteLine("Stopwatch started the Timer");
                        timer.Start();
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry...You already started the stopwatch. Type 'stop'");
                        i = i;
                    }

                }

                if (finalInput == "stop")
                {
                    if (i == 2)
                    {
                        Console.WriteLine("Timer Stoped");
                        timer.Stop();
                        i++;
                    }
                    else
                    {
                        Console.WriteLine("Sorry...You need to start the Timer first. Type 'start'");
                    }
                }
            }
            var timeElapsed = timer.Elapsed;
            Console.WriteLine("Time taken between Start and Stop is: " + timeElapsed);
        }
    }
}
