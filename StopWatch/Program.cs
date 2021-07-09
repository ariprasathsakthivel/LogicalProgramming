
using System;

namespace StopWatch
{
    class Program
    {
        static void Main(string[] args)
        {
            ElapsedTime();
        }
        static void ElapsedTime()
        {
            int startTimeSeconds = 0;
            int elaspedTimeMinutes, elapsedTimeSeconds;
            Console.WriteLine("Press spacebar to start the stopwatch");
            Console.WriteLine("Press spacebar at anytime to stop the stopwatch");
            Console.ReadKey();
            Console.WriteLine("Stopwatch started");
            while (!Console.KeyAvailable)
            {
                startTimeSeconds += 1;
            }
            Console.WriteLine("Stopwatch stopped");
            elaspedTimeMinutes = startTimeSeconds / 60;
            elapsedTimeSeconds = startTimeSeconds % 60;
            Console.WriteLine(startTimeSeconds);
            Console.WriteLine("{0} Minutes {1} seconds", elaspedTimeMinutes, elapsedTimeSeconds);
        }
    }
}
