using System;
using System.Text;
namespace String
{
    public class Program
    {
        public static void Main(string[] Args)
        {
            Console.WriteLine("Enter FirstName: ");
            string firstString = Console.ReadLine();

            Console.WriteLine("Enter LastName:");
            string secondString = Console.ReadLine();


            var stringbuild = new StringBuilder();
            stringbuild.Append(firstString+secondString);
            var stringlength = stringbuild.Length;
            Console.WriteLine("Length of the string is : ");
            Console.WriteLine(stringlength);
            stringbuild.Replace(firstString, secondString);

            Console.WriteLine(stringbuild);

            stringbuild.Replace(firstString, secondString);

            Console.WriteLine("Enter Middle Name: ");
            string middlename = Console.ReadLine();

            stringbuild.Insert(1, middlename);

            Console.WriteLine($"Your FirstName is {firstString}, Middle Name is {middlename} and LastName is {secondString}");


            
        }
    }
}
