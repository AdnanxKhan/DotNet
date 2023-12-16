using System;
using System.Drawing;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace ConsoleApp7
{
    public class Program
    {
       

        /*public float add(int b)
            {
            return b;
        }
        public int add(int a)
        {
            return a;
        }*/
        public static void Main(string[] args)
        {
            /*
             * Console.WriteLine($"Setting: {Program.Setting}");
            Class2 obj1 = new Class2();

            Class2 original = new Class2 { X = 10, Y = 20 };
            Class2 obj = new Class2(original);
            Console.WriteLine(obj.X);
            Console.WriteLine(obj.Y);

            double price = 49.99;

            string discountedMessage = $"The discounted price is {price * 0.8:C2}";

            Console.WriteLine(discountedMessage);

            RefOut refOut = new RefOut();
            
            int a = 10;
            int b;
            
           refOut.RefOutM(ref a, out b);
            Console.WriteLine($"ref a: {a},out b: {b}");\
            */

            Numerable enunera = new Numerable();
            enunera.AddItem(1);
            enunera.AddItem(2);
            enunera.AddItem(4);

            foreach (int i in enunera)
            {
                Console.WriteLine(i);
            }


        }
    }
}