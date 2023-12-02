using System;
using System.Text;
namespace Day3
{
    internal class Program
    {


        public static void Main(string[] args)
        {
            /*
              //*EXERCise 1
             List<string> friendInputList = new List<string>();
             Console.WriteLine("Enter Names of Friends press Enter without entering name when done : ");
             while (true)
             {
                 var userInput = Console.ReadLine();


                 if (String.IsNullOrEmpty(userInput))
                 {
                     break;
                 }
                 friendInputList.Add(userInput);

             }

             var g = friendInputList.Count;

             if (g == 0)
             {
                 Console.WriteLine("No one liked your post!");
             }
             else if(g == 1)
             {
                 Console.WriteLine(friendInputList[0] + " liked your post.");
             }
             else if (g == 2)
             {
                 Console.WriteLine(friendInputList[0] + " and " +friendInputList[1]+ " liked your post.");
             }
             else
             {
                 var t = g - 2;
                 Console.WriteLine(friendInputList[0] + " , " + friendInputList[1] + " and " +t+ " other  people liked your post.");
             }

             //*EXERCISE 2
             Console.WriteLine("Enter your name : ");
             var yourname = Console.ReadLine();
             char[] name = yourname.ToCharArray();
              Array.Reverse(name);
             Console.WriteLine("Reversed name is " );
             foreach( char c in name ) Console.Write(c);

             //EXERCISE 3
             int[] numbers = new int[5];

             Console.WriteLine("Enter 5 unique numbers :");

                 for (int i = 0; i < 5; i++)
                 {
                 int inputnumber;
                 bool isUnique = true;
                 do
                      {
                        inputnumber = Convert.ToInt32(Console.ReadLine());
                     isUnique = true;
                     for (int j = 0; j < i; j++)
                         {
                              if (numbers[j] == inputnumber)
                                 {
                                    Console.WriteLine("Please Enter a Unique Number.");
                                    isUnique = false;
                                    break;
                                }

                           }

                        } while (!isUnique) ;

                 numbers[i] = inputnumber;
             }

             Array.Sort(numbers);
             Console.WriteLine("Sorted Numbers Are :");
             foreach (int i in numbers)
             {
                 Console.WriteLine(i);
             }

             //EXERCISE 4
             List<int> numberList = new List<int>();
             Console.WriteLine("Enter Numbers : ");
             while (true)
             {
                 var userInput = Console.ReadLine();
                 if (string.IsNullOrEmpty(userInput))
                 {
                     break;
                 }


                 numberList.Add(Convert.ToInt32(userInput));


             }
             for (int i = 0; i < numberList.Count; i++)
             {
                 if (i == numberList[i])
                 {
                     numberList.RemoveAt(i);
                 }
             }
             foreach (int number in numberList) {
                 Console.WriteLine(number);
             }

             //EXERCISE 5

         Console.WriteLine("Enter a series of number seperated by commas: ");
             string input = Console.ReadLine();
             int[] numberss = input.Split(',').Select(number => int.Parse(number)).ToArray();

             Array.Sort(numberss);
             for (int i = 0; i <3; i++) {
                 Console.WriteLine(numberss[i]);
             }

             var dateTime= new DateTime(2023,12,2);
             var now = DateTime.Now;
             var today = DateTime.Today;
             Console.WriteLine("Hour: "+now.Hour);
             Console.WriteLine("Minute" +now.Minute);
             var tomorrow = now.AddDays(1);
             var yesterday = today.AddDays(-1);
             Console.WriteLine(now.ToLongDateString());
             Console.WriteLine(now.ToShortDateString());
             Console.WriteLine(now.ToShortTimeString());
             Console.WriteLine(now.ToLongTimeString());
             Console.WriteLine(now.ToString("dd-mm-yyyy"));
           
            var timespan = new TimeSpan(1,2,3);
            var timespan1 = TimeSpan.FromHours(1);
            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(1);
            var duration = end - start;
            Console.WriteLine("Duration: "+duration);
            Console.WriteLine("minutes: "+timespan.Minutes);
            Console.WriteLine("Total Minutes: "+timespan.TotalMinutes);
            Console.WriteLine("Add: "+timespan.Add(TimeSpan.FromMinutes(2)));
            Console.WriteLine("To String: "+ timespan.ToString());
            

            var fullName = "Adnan Khan.";
            Console.WriteLine("Trim : '{0}'",fullName.Trim());
            Console.WriteLine("Trim : '{0}'",fullName.ToUpper());
            Console.WriteLine("Trim : '{0}'",fullName.ToLower());
            var index = fullName.IndexOf(' ');
            var firstname = fullName.Substring(0,index);
            var lastname = fullName.Substring(index+1);
            Console.WriteLine(firstname);
            Console.WriteLine(lastname);
            var newlastname = fullName.Replace("Khan.", "Khan");
            Console.WriteLine(newlastname);
            var str = 12.98f;
            Console.WriteLine(str.ToString("C1"));

            

            var sentence = "This is going to be a very very very very very very long saturday";
            var summary = SummarizeText.summarizeText(sentence,20);
            Console.WriteLine(summary);

            var builder=new StringBuilder();
            builder.Append('-',10)
                    .AppendLine()
                    .AppendLine("Header")
                    .Append('-', 10)
                    .Replace('-', '+')
                    .Remove(0,10)
                    .Insert(0, new string('-', 10));
            Console.WriteLine(builder);

            //EXERCISE 1
            List<int> list = new List<int>();
            Console.WriteLine("Enter 5 numbers: ");
            for (int i = 0; i < 5; i++)
            {
                int newnnum =Convert.ToInt32(Console.ReadLine());
                list.Add(newnnum);

            }
            foreach (int s in list)
            {
                Console.WriteLine(s);
            }
            int a = list[0];
            int b = list[1];
           int c = a+1;
            Console.WriteLine(c);
            if (b == c)
            {
                Console.WriteLine("Consecutive Numbers");
            }
            else
            {
                Console.WriteLine("Non Consecutive Numbers");
            }
            

            Console.WriteLine("Enter a series of number seperated by hyphen: ");
            string input = Console.ReadLine();
            int[] numbersss = input.Split('-').Select(number => int.Parse(number)).ToArray();

            Array.Sort(numbersss);
            for (int i = 0; i < numbersss.Length; i++)
            {
                if (numbersss[i] == numbersss[i+1])
                {
                    Console.WriteLine("Duplicates");
                    break;
                }

                else
                {
                    Console.WriteLine("No Duplicates");
                    break;
                }
            }
       
            Console.WriteLine("Enter Time in 24 Hour Format(HH:mm): ");
            string userInputTIme = Console.ReadLine();
            DateTime time;
            if (DateTime.TryParseExact(userInputTIme,"HH:mm",null, System.Globalization.DateTimeStyles.None,out time))
            {
                Console.WriteLine("Valid Time");

            }
            else
            {

                Console.WriteLine("Invalid Time");

            }
                 
     
                Console.Write("Enter a few words separated by a space: ");
                string userInput = Console.ReadLine();

                string result = Class1.ConvertToPascalCase(userInput);
                Console.WriteLine("PascalCase: " + result);
            }
            */
         
            Console.WriteLine("Enter your Word : ");
            var yourWord = Console.ReadLine();
            char[] word = yourWord.ToCharArray();
            var vowels = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a'|| word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u')
                { 


                    vowels++;
                    

                }


            }
            Console.WriteLine(vowels);
        }
             

        }
    
}






   