using System;
using System.Runtime.CompilerServices;
namespace Constructor

{
    public partial class Program
    {   
        public static void Main(string[] args)
        {
           
            var customer = new Customer(1); 
            customer.Id = 1;
            customer.Name = "Test";
            var order = new Order();
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            foreach (var item in customer.Orders)
            {
                Console.WriteLine(item);
            }
            /*
             Console.WriteLine("Enter Customer ID: ");
             int customerId= int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Customer Name: ");
             string customerName = Console.ReadLine();

             var customer = new Customer(customerId, customerName);

             Console.WriteLine("Enter the Number of Orders: ");
             int numberOfOrders = int.Parse(Console.ReadLine());




             var order = new Order();
             customer.Orders.Add(order);
             var ordercount = numberOfOrders;
             var newNumberOfOrders = numberOfOrders++;

             Console.WriteLine($"Customer ID :{customer.Id}");
             Console.WriteLine($"Customer Name :{customer.Name}");
             Console.WriteLine("Total Number of Orders : "+newNumberOfOrders);
             */
        }
    }
}