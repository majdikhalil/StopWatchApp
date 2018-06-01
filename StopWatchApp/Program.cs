using System;

namespace StopWatchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new StopWatch();
            try
            {
                while (true)
                {


                    if (!stopWatch._isRunning)
                    {
                        Console.WriteLine("Please Press S to start and X to stop the watch, Press xx to quit");
                    }

                    else
                    {
                        Console.WriteLine("Please Press X to stop the watch, Press xx to quit");
                    }


                    var input = Console.ReadLine().ToLower();

                    if (input == "xx")
                    {
                        break;

                    }
                    else if (input == "s")
                    {
                        stopWatch.Start();

                    }

                    if (input == "x")
                    {
                        stopWatch.Stop();
                        stopWatch.DisplayDuration();
                    }

                }


            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);

            }

        }
    }
}