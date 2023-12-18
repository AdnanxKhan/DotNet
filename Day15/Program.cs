using System;

namespace ConsoleApp8
{
    public interface Interface1
    {
        int Add(int a, int b);
    }

    public interface Interface2
    {
        int Add(int a, int b);
    }
    public class Other : Interface1, Interface2
    {
        public int Add(int a, int b)
        {
            
            Console.WriteLine("common method");
            return 0;
        }
    }
    public class Program : Other
    {
      
        public static void Main(string[] args)
        {
         
            

            //Interface1 if1 = new Program();
            //Interface2 if2 = new Program();

            //int result1 = if1.Add(5, 3);
            //int result2 = if2.Add(5, 3);

            //Console.WriteLine(result1);
            //Console.WriteLine(result2);
            
            Other other = new Other();
            
            
            
        }
    }
}