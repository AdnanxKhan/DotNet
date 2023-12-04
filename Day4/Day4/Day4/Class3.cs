using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    public class Person
    {
        public static string name;
        public static void Introduce (string to) 
        {
            
            Console.WriteLine("Hi {0}, I am {1}", to, name);
        }
        public static Person Parse(string str)
        {
            var person = new Person();
            Person.name = str;
            return person;

        }

    }

}
