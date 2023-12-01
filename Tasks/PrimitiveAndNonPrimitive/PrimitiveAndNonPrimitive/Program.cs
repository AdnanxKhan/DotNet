using System;
using System.Runtime.InteropServices;
using static PrimitiveAndNonPrimitive.Program;
namespace PrimitiveAndNonPrimitive
{
    public partial class Program
    {
        public class Man
        {
            public int Age;
        }
        public static void Main(String[] Args)
        {
            Console.WriteLine("Primitive Types: ");
            int variable = 1;
            Console.WriteLine("Variable is " +variable);
            const int constant = 10;
            Console.WriteLine("Constant variable is "+constant);
            Console.WriteLine("Overflow");

            checked
            {
                byte nnumber = 254;
                nnumber += 1;

                Console.WriteLine(nnumber);
             }

            string s = "2";
            int i = Convert.ToInt32(s);
            Console.WriteLine("String " + s + " is converted to Int " + i);
            Console.WriteLine("Casting");
            byte b = 1;
            int j = (byte)b;
            Console.WriteLine(j);
            Console.WriteLine("Operators");
            int a = 10;
            int f = 20;
            int c = 0;
            Console.WriteLine("Addition = {0} ",c=a+f);
            int k = a - f;
            Console.WriteLine("A " + a + " - B is " + b + " C = " + k);
            Console.WriteLine("Comparing if c(30) is greater than a(10) and f(20) = {0}",c > a && c> f);
            Console.WriteLine("Non Primitive Types : ");
            var adnan = new person();
            adnan.firstname = "Adnan";
            adnan.lastname = "Khan";
            adnan.Introduce();
            var calculate = new Calculator();
            var result = calculate.Add(10, 20);
            Console.WriteLine(result);
            Console.WriteLine("ARRAYS:");
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 2;
            Console.WriteLine(string.Format("array1[0]:{0}, array2[0]:{1}", array1[0], array2[0]));
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            //REFERENCE TYPE
            var person = new Man() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);
            static void Increment(int number)
            {
                number += 10;

            }
            static void MakeOld(Man person)
            {
                person.Age += 20;
            }
            //IF ELSE
            Console.WriteLine("Enter time of the day");
            int hour = Convert.ToInt32(Console.ReadLine());
            if (hour < 12)
            {
                Console.WriteLine("Its Morning");
            }
            else if (hour >= 12 && hour <= 16)
            {
                Console.WriteLine("Its Afternoon");
            }
            else { Console.WriteLine("Its Evening"); }
            Console.WriteLine("Conditional Value of Price: ");
            bool isGoldCustomer = false;
            float price = (isGoldCustomer) ? 52f : 62f;
            Console.WriteLine(price);
            Console.WriteLine("Enum & Switch Case: ");
            var seasons = Seasons.Autumn;
            switch (seasons)
            {

                case Seasons.Summer:
                    Console.WriteLine("Its Summer Season");
                    break;
                case Seasons.Autumn:
                    Console.WriteLine("Its Autumn Season");
                    break;
                case Seasons.Monsoon:
                    Console.WriteLine("Its Monsoon Season");
                    break;
                case Seasons.Spring:
                    Console.WriteLine("Its Spring Season");
                    break;
                case Seasons.Winter:
                    Console.WriteLine("Its Winter Season");
                    break;
            }
        }
    }
}

