
using System;
namespace IEnumerable
{
    public class Program
    {
        public static void Main(string[] args) 
        {

            Console.WriteLine("IEnumerable ");
            var employees = new List<Employee>()
            {
                new Employee(){Id = 1, Name = "Bill", Salary =20000},
                new Employee(){Id = 2, Name = "Adnan ", Salary = 10000},
                new Employee(){Id = 3, Name = "George ", Salary = 1000},
                new Employee(){Id = 4, Name = "John", Salary = 16000}
            };
            IEnumerable<Employee> salary = employees.Where(l => l.Salary > 15000).AsEnumerable<Employee>();
            foreach (Employee employee in salary)
            {
                Console.WriteLine(employee.Id + " " + employee.Name);
            }
            Console.WriteLine();
            Console.WriteLine("IQueryable");
      
            IQueryable<Employee> newsalary = employees.Where(l => l.Salary > 15000).AsQueryable<Employee>();
            foreach (Employee employee in newsalary)
            {
                Console.WriteLine(employee.Id + " " + employee.Name);
            }
        }
    }
}