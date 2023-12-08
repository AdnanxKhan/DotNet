using System;
using System.Collections;
namespace Day8
{
    public class Program
    {
    
        public static void Main(string[] args) 
        {


            List<Employee> list = new List<Employee>()
            {
                new Employee { name = "Adnan", id = 1, age=23, salary = 10000, incentive=9000},
                new Employee { name = "Lex", id = 2 , age = 20, salary = 32000, incentive=2000},
                new Employee { name = "Juan", id = 3 , age = 34, salary = 30000, incentive=6000},
                new Employee { name = "Hose", id = 4 , age =30, salary = 14000, incentive=1000},

            };
            //ArrayList array = new ArrayList();
            //array.Add(1);
            //array.Add("llol");
            var array = new ArrayList { 1, "Adnan", 10000, 25 };

            foreach ( var arr1 in array )
            {
                Console.WriteLine(arr1);
            }
           
            var sortByAge = list.OrderBy(e => e.age); 
            double avgSalary = list.Average(e=>e.salary);
            var find = list.Find(e => e.id == 1);
            Console.WriteLine($"Found employee with 1 {find.name}");
            Console.WriteLine(avgSalary);

            foreach (var e in sortByAge)
            {
                Console.WriteLine($"ID : {e.id}, Name: {e.name}");

            }
            List<int> newlist = new List<int>() {1,2,3,4,5,6,7,8,9,10 };
            var sum = list.Aggregate(0,(acc,employee) => acc+ employee.incentive+ employee.salary );
            Console.WriteLine(sum);
        }
    }
}
