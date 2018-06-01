using System;
using System.Collections.Generic;

namespace StopWatchApp
{
    public class StopWatch
    {

        //Properties 
        DateTime _startTime;

        DateTime _stopTime;

        public bool _isRunning;

        public void Start()
        {
            if (_isRunning)
            {
                throw new InvalidOperationException("Cannot start: Already Running");
            }

            _startTime = DateTime.Now;
            _isRunning = true;

        }

        //stop method

        public void Stop()
        {
            var currentYear = DateTime.Now.Year;
            if (!_isRunning || _startTime.Year < currentYear)
            {
                throw new InvalidOperationException("Can't Stop: Not running");
            }


            _stopTime = DateTime.Now;
            _isRunning = false;

        }

        public TimeSpan Duration()
        {

            if (_isRunning && _startTime != null)
            {
                _stopTime = DateTime.Now;
                _isRunning = false;
                return _stopTime - _startTime;
            }
            else
            {
                return _stopTime - _startTime;
            }

        }

        public void DisplayDuration()
        {
            var timeLapse = Duration();
            Console.WriteLine("Total Time: {0}", timeLapse);
        }



    }
}