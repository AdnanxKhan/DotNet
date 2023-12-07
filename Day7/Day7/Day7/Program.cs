using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using Math;

namespace Day7
{
    public class Program
    {
        public void New(int a)
        {
            a = 1;
        } 
        public void New(float a)
        {
            a = 10;
        }
        public static void ReadITenTimes()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static async void Method()
        {
            await Task.Run(LongTask);
            Console.WriteLine("New Thread");
        }
        public static void LongTask()
        {
            Thread.Sleep(100);
        }

        public  static async void Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Starting Task...... ");
                Thread.Sleep(3000);
                Console.WriteLine("Finishing Task.......");
                Console.WriteLine("Finished Task1");
            });
            
        }
        public  static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Starting Task...... ");
                Thread.Sleep(5000);
                Console.WriteLine("Finishing Task.......");
                Console.WriteLine("Finished Task2");
            });

        }
        public  static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Starting Task...... ");
                Thread.Sleep(2000);
                Console.WriteLine("Finishing Task.......");
                Console.WriteLine("Finished Task3");
            });

        }

        public  static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Starting Task...... ");
                Thread.Sleep(6000);
                Console.WriteLine("Finishing Task.......");
                Console.WriteLine("Finished Task4");
            });

        }

        public  static async void Task5()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Starting Task...... ");
                Thread.Sleep(4000);
                Console.WriteLine("Finishing Task.......");
                Console.WriteLine("Finished Task5");
            });

        }
        public static void Task6()
        {
           
                Console.WriteLine("Starting Task...... ");
                Thread.Sleep(4000);
                Console.WriteLine("Finishing Task.......");
                Console.WriteLine("Finished Task5");
            

        }



        public static void Main(string[] args)
        {
            /*
            int n1 = 2;
            int n2 = 3;
            Console.WriteLine($"The sum of {n1} and {n2} is {n1+n2}");
            Console.WriteLine("Enter FirstName : ");
            string s = Console.ReadLine();

            Console.WriteLine($"Please add surname beside your name {s}");
            string y = Console.ReadLine();
            Console.WriteLine($" Full name is {s} {y}");

            Class1.AddName();
            Console.WriteLine("IEnumerable & IQueryable");
            var employees = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Bill", Salary =20000},
                new Employee(){Id = 2, Name = "Adnan ", Salary = 10000},
                new Employee(){Id = 3, Name = "George ", Salary = 1000},
                new Employee(){Id = 4, Name = "John", Salary = 16000}
            };
            IQueryable<Employee> salary = employees.Where(l=>l.Salary>15000).AsQueryable<Employee>();
            foreach ( Employee employee in salary ) 
            {
                Console.WriteLine(employee.Id + " " + employee.Name);
            }
                for (int i = 0;i <= 5; i++) 
            {
                Console.WriteLine(i);
                Thread.Sleep(2000);
            }
        }
            
             for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
                 Parallel.For(0, 100, x => ReadITenTimes());
            
            Method();
            Console.WriteLine("Main Thread");
            //List<string> food = new List<string>();
            ArrayList list = new ArrayList();
             
            var add = new Addition();
            add.Add(10, 20);
            
            Console.WriteLine("LINQ");
            List<Student> students = Student.GetAllStudents();
            var Malestudents = students.Where((l => l.Gender == "Male")).OrderBy(l => l.Id).ToList() ;


            Console.WriteLine("Male Students Are: ");
            foreach (var student in Malestudents)
            {
                Console.WriteLine("{0} {1}",student.Id,student.Name);
            }

            Console.WriteLine("Nullable");
            int? s = 10;
            int? g = null;
            int a = g ?? 20;

            Console.WriteLine(a);

            Console.WriteLine("VAR and DYNAMIC");


            var a = "happy";
            a = Convert.ToString((10));

            Console.WriteLine(a);

            dynamic b = 10;
            b = "WOW";

            Console.WriteLine(b);

      
            Console.WriteLine("Try Catch");
            double a;
            double b;
            double result;
            try
            {
                Console.WriteLine("Enter 1st Number: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                b = Convert.ToDouble(Console.ReadLine());
                result = a / b;
                Console.WriteLine(result);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Enter only Numbers ");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot divide by 0");
            }
            
       
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();
         Console.ReadLine();
             */
            int num = 2;
            int num1;

            Increment(ref num, out num1);
            Console.WriteLine($"Reference is {num} and Out is {num1}");

        }
        public static void Increment(ref int x, out int y)
        {
            int a = 10;
            x = x + 1;
            y = a-2;
        }

    }
}