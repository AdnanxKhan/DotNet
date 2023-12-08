using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskParallelLibrary
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Main Thread ID: " + Thread.CurrentThread.ManagedThreadId);


            Task task1 = Task.Run(() => DoWork(1));
            Task task2 = Task.Run(() => DoWork(2));
            Task task3 = Task.Run(() => DoWork(3));


            Task.WaitAll(task1, task2, task3);

            Console.WriteLine("All tasks are completed.");
        }

        public static void DoWork(int taskId)
        {
            Console.WriteLine($"Task {taskId} started on Thread ID: {Thread.CurrentThread.ManagedThreadId}");
           
            Thread.Sleep(2000);
            Console.WriteLine($"Task {taskId} completed on Thread ID: {Thread.CurrentThread.ManagedThreadId}");
        }
    }
}
