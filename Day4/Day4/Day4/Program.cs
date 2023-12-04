using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Day4
{



    public partial class Program
    {

        /*
       var content = @"C:\Users\rupes\Desktop\image.txt";

       File.Copy(@"c:\temp\image.txt",@"c:\dest\image2.txt");
       File.Delete(path);
       var content = File.ReadAllText(@"C:\Users\rupes\Desktop\image1.txt");
       Console.WriteLine(content);
       var newpath = @"C:\Users\rupes\Desktop\newimage.txt";
       var fileInfo = new FileInfo(content);
       fileInfo.CopyTo(newpath);
       Directory.CreateDirectory(@"C:\Users\rupes\Desktop\folder1");
       var files = Directory.GetFiles(@"C:\Users\rupes\Desktop","*.txt", SearchOption.AllDirectories);
       foreach (var file in files) 

           Console.WriteLine(file);

       var directory = Directory.GetDirectories(@"C:\Users\rupes\Desktop","*.*",SearchOption.AllDirectories);
       foreach (var dir in directory) {
           Console.WriteLine(dir);
       } 

       var directoryPath = @"C:\Users\rupes\Desktop\image1.txt";

       var dotIndex = directoryPath.IndexOf('.');
       var extension = directoryPath.Substring(dotIndex);

       Console.WriteLine("Extension : "+ Path.GetExtension(directoryPath));
       Console.WriteLine("FileName: "+ Path.GetFileName(directoryPath));
       Console.WriteLine("File Name without extension : " + Path.GetFileNameWithoutExtension(directoryPath));
       Console.WriteLine("Directory Name: " + Path.GetDirectoryName(directoryPath));

       var newpath = @"C:\Users\rupes\Desktop\image1.txt";
       Console.WriteLine(File.ReadAllText(newpath));
       var content = File.ReadAllText(newpath);

       int wordCount = Class1.CountWords(content);

       Console.WriteLine(wordCount);

       string longestWord = Class2.LongestWord(content);
       Console.WriteLine(longestWord);


       Console.WriteLine("Enter a series of number seperated by commas: ");
       string input = Console.ReadLine();
       int[] numberss = input.Split(',').Select(number => int.Parse(number)).ToArray();

       Array.Sort(numberss);
       for (int i = 0; i < 3; i++)
       {
           Console.WriteLine(numberss[i]);
       }

       var person =Person.Parse("Test");
       Person.Introduce("Adnan");
           


        public class Customer
        {
            public string Name;

            public Customer(string name)
            {
                this.Name = name;
            }
        }
        public class Per
        {
            private DateTime _birthdate;
            public void SetBirthdate(DateTime birthdate)
            {
                _birthdate = birthdate;
            }
            public DateTime Get_birthdate()
            {
                return _birthdate;
            }
        }
       


            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1,2));
            Console.WriteLine(calculator.Add(1,2,3,4));
            Console.WriteLine(calculator.Add(new int[] {1,2,3,4,5}));

            var per = new Per();
            per.SetBirthdate(new DateTime(2000,7,21));
             Console.WriteLine(per.Get_birthdate());
            var text = new Class5.Text();
            text.fontsize = 12;
            Console.WriteLine(text.fontsize);
        */



      

        public static void Main(string[] args)
        {

            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);
            dbMigrator.Migrate();
            installer.Install();


             


        }
    }
}