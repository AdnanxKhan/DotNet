using System;
using System.Collections;
using System.Numerics;
namespace Day5
{
    public partial class Program
    {

        public static void Main(string[] args)
        {
            //var car = new car("MH04GD8733");
            //Console.WriteLine(car);

            //text text = new text();
            //Shape shape = text;
            //text.width = 12;
            //shape.width = 22;
            //Console.WriteLine(text.width);
            //Shape shape = new text();
            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Adnan");
            //list.Add(DateTime.Now);
            //var anotherList = new List<int>();
            //var lol = "Expression";
            //anotherList.Add(1);
            //foreach (var item in anotherList)
            //{
            //    Console.WriteLine(item);
            //}

            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 190f };
            orderProcessor.Process(order);


        }
    }
}