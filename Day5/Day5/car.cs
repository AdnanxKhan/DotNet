namespace Day5
{
    public partial class Program
    {
        public class car : vehicle
        {
            public car(string registrationNumber)
                :base(registrationNumber)
            {

                Console.WriteLine("Car is being initialised {0}",registrationNumber);
            }
          
        }
    }
}