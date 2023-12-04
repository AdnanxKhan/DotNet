using System;
namespace Overriding
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Calculator");
            var add = new Add();
            Console.WriteLine(add.Sum(3000,500000));
        }
    }
}