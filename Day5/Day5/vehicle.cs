namespace Day5
{
    public partial class Program
    {
        public class vehicle
        {
            private string _registrationNumber;
            //public vehicle(string registrationNumber)
            //{
            //    _registrationNumber = registrationNumber;
            //}
            //public vehicle()
            //    {
            //    Console.WriteLine("Vehicle is being initialised");
            //    }

            public vehicle(string registrationNumber)
            {
                _registrationNumber = registrationNumber;
                Console.WriteLine("Vehicle is being initialised {0}",registrationNumber);
            }
        }
    }
}