using System;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
namespace ConsoleApp1
{
    /* 
     * NON PRIMITIVE TYPE _ ENUM
     * public enum ShippingMethod 
     {
         AmericanExpress = 1,
         IndianExpress = 2,
         JantaExpress = 3

     }
    public class Person
    {
        public int Age;
    }*/
    public class Program
     {
         /* static int a = 10, b = 30;
         static int c = a + b;
         public string name;
         public void Introduce()
         {
             Console.WriteLine("Hii My Name is "+name);
         }*/

    public static void Main(string[] args)
        {
            /*var class1 = new Values();
            var conv = new Conversion();
            Console.WriteLine(Conversion.number);
            Console.WriteLine(c);
            var Program = new Program();
            Program.name = "Adnan";
            Program.Introduce();
            //CALCULATOR
            int result = Calculator.Add(3,5);
            Console.WriteLine(result);
            //ARRAY
            var numericalArray = new int[3];
            numericalArray[0] = 1;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(numericalArray[i]);
            }
            Console.WriteLine(numericalArray[1]);
            Console.WriteLine(numericalArray[2]);
            var boolarray = new bool[3];
            boolarray[0] = true;
            Console.WriteLine(boolarray[0]);
            Console.WriteLine(boolarray[1]);
            Console.WriteLine(boolarray[2]);

            var names = new string[3] { "Adnan","Jeet","Brijesh" };
            Console.WriteLine(names[0]);
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(names[i]);
            }
            //STRING
            var firstname = "Adnan";
            var lastname = "Khan";
            var fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);
            var myfullName = string.Format("My Fullname is {0} {1}", firstname, lastname);
            Console.WriteLine(myfullName);
            var names = new string[3] { "Adnan","Adnan2","Adnan3"};
            var formattednames = string.Join(", ", names);
            Console.WriteLine(formattednames);
            var text = @"I 
Said 
Never 
DO 
That 
AGAIN";
            Console.WriteLine(text);
            //ENUM

            var method= ShippingMethod.AmericanExpress;
            Console.WriteLine((int)method);
            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);
            var methodName = "JantaExpress";
            var shippingMethod = (ShippingMethod) Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
            //ARRAYS
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0}, b: {1}",a,b));
            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 2;
            Console.WriteLine(string.Format("array1[0]:{0}, array2[0]:{1}", array1[0], array2[0]));
            //NON PRIMITIVE TYPE
             //VALUE TYPE
            var number = 1;
            Increment(number);
            Console.WriteLine(number);
            
            //REFERENCE TYPE
            var person = new Person() {Age = 20};
            MakeOld(person);
            Console.WriteLine(person.Age);
            static void Increment(int number)
            {
                number += 10;

            }
            static void MakeOld(Person person)
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
         
            bool isGoldCustomer=false;
            float price = (isGoldCustomer) ? 52f : 62f;
            Console.WriteLine(price);
              
            var seasons = Seasons.Autumn;
            switch(seasons)
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
            
            //EXERCISE
            //EXERCISE 1
            Console.WriteLine("Enter a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >=1 && number<=10) {

                Console.WriteLine("Valid");
            }
            else
            { Console.WriteLine("Invalid"); }
            

            //EXERCISE 2
            Console.WriteLine("Enter Two Numbers : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 < number2) {
                Console.WriteLine( number2 + " is greater than " + number1);
            }
            else
            {
                Console.WriteLine(number1 + " is greater than " + number2);
            }
            
            //EXERCISE 3
            Console.WriteLine("Enter Height and Width of the Image : ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1 < number2)
            {
                Console.WriteLine("It is a Landscape");
            }
            else
            {
                Console.WriteLine("It is a Potrait");
            }
            */
            //EXERCISE 4
            Console.WriteLine("Enter Speed of the Car (km/h) : ");
            int speedofthecar = Convert.ToInt32(Console.ReadLine());
            int speedlimit = 80;
            int demerit = 0;
             if (speedofthecar < speedlimit)
            {
                Console.WriteLine("It is OK.");
            }
            else 
            {
                int speeddifference = speedofthecar - speedlimit;
                demerit = speeddifference/5;
                Console.WriteLine("It is 1 Demerit Point ");
                Console.WriteLine("Total Demerit Points  "+demerit);
                if (demerit > 12)
                {
                    Console.WriteLine("License SUSPENDED.");
                }
            }
           
        }
    }
}