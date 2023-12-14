using System;
namespace Day13
{
    public class Program

    {
        public int a;
        public Program(int a)
        {
            this.a = a;
          
        }
        public Program(Program abc)
        {
            abc.a = a;
        }
        public static void Main(string[] args)
        {
      
            int value = new Program(1);
            var abc = new Program(2);
            Console.WriteLine(value);
            Console.WriteLine(abc);
        }
    }
}