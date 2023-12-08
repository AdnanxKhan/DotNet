using System;
namespace VarDynamicObject
{
    public class Program
    {
        public static void Main(String[] args)
        {
            var number = 10;
            var text = "Hello, World!";
            var flag = true;

            Console.WriteLine($"var Example:");
            Console.WriteLine($"Number: {number}, Type: {number.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"Text: {text}, Type: {text.GetType()}");
            Console.WriteLine();
            Console.WriteLine($"Flag: {flag}, Type: {flag.GetType()}");
            Console.WriteLine();
            Console.WriteLine();
            dynamic dynamicObject = 10;
            Console.WriteLine($"dynamic Example:");
            Console.WriteLine($"Dynamic Object: {dynamicObject}, Type: {dynamicObject.GetType()}");
            Console.WriteLine();
            dynamicObject = "Dynamic Text";
            Console.WriteLine($"Dynamic Object: {dynamicObject}, Type: {dynamicObject.GetType()}");
            Console.WriteLine();
            dynamicObject = true;
            Console.WriteLine($"Dynamic Object: {dynamicObject}, Type: {dynamicObject.GetType()}");
        }


    }
}

