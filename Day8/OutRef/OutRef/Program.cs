using System;
namespace OutRef
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int num = 2;
            int num1;

            Increment(ref num, out num1);
            Console.WriteLine($"Reference is {num} and Out is {num1}");

        }
        public static void Increment(ref int x, out int y)
        {
            int a = 10;
            x = x + 1;
            y = a - 2;
        }

    }
}
