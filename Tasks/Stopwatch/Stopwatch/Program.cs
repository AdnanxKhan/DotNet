using System;

namespace Stopwatch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            Console.WriteLine("StopWatch");
            while (true)
            {
                Console.WriteLine("Type 'start' to Start and 'stop' to Stop: ");
            var startOrStop = Console.ReadLine();

           
            
                if(startOrStop == "start")
                {
                    stopwatch.Start();
                }
            else if (startOrStop == "stop")
                {
                    stopwatch.Stop();
                }
                else
                {
                    Console.WriteLine("Enter start or stop");
                }
            }
        }
    }
}




















//switch (startOrStop)
//{
//    case "start":
//        stopwatch.Start();
//        break;

//    case "stop":
//        stopwatch.Stop();
//        break;

//    default:
//        Console.WriteLine("Enter 'start' or 'stop' ");
//        break;
//}
//Console.WriteLine();