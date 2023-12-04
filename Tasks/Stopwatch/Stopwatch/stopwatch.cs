using System;

namespace Stopwatch
{
    internal class Stopwatch
    {
        private bool isRunning;
        private DateTime startNow;
        private DateTime stopNow;

        public void Start()
        {
            if (isRunning)
            {
                throw new InvalidOperationException("Stopwatch is already running.");
            }

            startNow = DateTime.Now;
            isRunning = true;
            Console.WriteLine("Stopwatch started.");
        }

        public void Stop()
        {
            if (!isRunning)
            {
                throw new InvalidOperationException("Stopwatch is not running.");
            }

            stopNow = DateTime.Now;
            isRunning = false;
            Console.WriteLine("Stopwatch stopped.");

            TimeSpan duration = stopNow - startNow;
            Console.WriteLine($"Duration: {duration}");
        }
    }
}
