using System;
using System.Collections.Generic;

namespace StopWatchApp
{
    public class StopWatch
    {
        private DateTime StartTime { get; set; }
        private DateTime StopTime { get; set; }
        private bool StopWatchStarted { get; set; }
        private readonly List<TimeSpan> _durationIntervals;

        public TimeSpan Duration
        {
            get
            {
                var totalDuration = TimeSpan.Zero;
                foreach (TimeSpan timeSpan in _durationIntervals)
                {
                    totalDuration += timeSpan;
                }
                return totalDuration;
            }
        }

        public StopWatch()
        {
            StopWatchStarted = false;
            _durationIntervals = new List<TimeSpan>();
        }

        public void Start()
        {
            if (!StopWatchStarted)
            {
                StartTime = DateTime.Now;
                Console.WriteLine("Start Pressed");
                StopWatchStarted = true;

            }
            else
            {
                throw new InvalidOperationException(nameof(StartTime));
            }

        }

        public void Stop()
        {
            Console.WriteLine("Stop Pressed");
            if (StopWatchStarted)
            {
                StopTime = DateTime.Now;
                StopWatchStarted = false;
                AddDurationToList();
            }


        }

        private void AddDurationToList()
        {
            _durationIntervals.Add((StopTime - StartTime));
        }

    }
}