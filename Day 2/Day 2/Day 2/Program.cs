using System;
namespace Day_2
{

    public class Program
    {
        public static void Main(string[] args)
        {
            /*for (int i = 0; i <=10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            } 
            for (int i = 10; i >=0; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            var name = "Adnan Khan";
            for (var i = 0;i < name.Length; i++)
            {
                Console.WriteLine(name[i]);
            }
            foreach(var character in name)
            {
                Console.WriteLine(character);
            }
            var numbers= new int[] { 1, 2, 3};
            foreach (var character in numbers)
            {
                Console.WriteLine(character);
            }
            var j = 0;
            while (j<=10)
            {
                if(j%2==0)
                Console.WriteLine(j);
                j++;
            }
            while(true)
            {
                Console.WriteLine("Enter Your Name: ");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                    continue;
                Console.WriteLine("Your Name is : "+input);
            }
            */
            var random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 10));
            }

        }
    }
}