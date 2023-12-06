using System;
namespace Day6
{
    
    public class Program 
    {
        public static void displayELements<Thing>(Thing[] array)
        {

            foreach (Thing item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine();
        }


        public static void Main(string[] args)
        {
            Console.WriteLine("Interfaces");
            var dbMigrator = new DBMigrator(new Filelogger("C:\\Users\\rupes\\Desktop\\folder1log.txt"));
            dbMigrator.Migrate();

            Console.WriteLine("GENERICS");

            int[] intArray = { 1, 2, 3 };
            double[] doubleArray = { 1.0, 2.0, 3.0 };
            string[] stringArray = { "Adnan", "Khan", "Lol" };

            displayELements(stringArray);
            displayELements(intArray);
            displayELements(doubleArray);



            Console.WriteLine("DELEGATES");


            var processor = new Photoprocessor();
            var filters = new PhotoFilters();
            Photoprocessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;
            filterHandler += filters.ApplyContrast;
            filterHandler += filters.Resize;
            processor.Process("photo.jpg", filterHandler);


            Console.WriteLine("");
            Console.WriteLine("Lambda Expressions");

            Func<int, int> square = number => number * number;
            Console.WriteLine(square(5));


            var books = new BookRepository().GetBooks();
            var cheapbooks = books.FindAll(book => book.Price < 10);
            foreach(var book in cheapbooks)
            {
                Console.WriteLine(book.Title);
            }

        }

    }
}
