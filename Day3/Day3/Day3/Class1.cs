using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class Class1
    {
        public static string ConvertToPascalCase(string words)
        {
            // Split the input words
            string[] wordsArray = words.Split(' ');

            // Capitalize the first letter of each word and join them
            for (int i = 0; i < wordsArray.Length; i++)
            {
                wordsArray[i] = Class2.CapitalizeFirstLetter(wordsArray[i]);
            }

            string pascalCase = string.Join("", wordsArray);
            return pascalCase;
        }

    }
}
