using System;
namespace Overloading
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var point = new Point(10, 20);
          //  point.Move(20, 5);
            point.Move(new Point(3,20));
            Console.WriteLine("Point is at: {0},{1}", point.X, point.Y);
            point.Move(100,2000);
            Console.WriteLine("Point is at: {0},{1}", point.X, point.Y);

        }

    }
}
