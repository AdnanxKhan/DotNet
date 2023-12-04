using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Class2
    {
        public static string LongestWord(string text)

        {
            string[] words = text.Split(new char[] { ' ', 't', 'r', 'n' });

            string longestWord = "";
            int maxLength = 0;

            foreach (string word in words)
            {
                if (word.Length > maxLength)
                {

                    maxLength = word.Length;
                    longestWord = word;
                }

            }
            return longestWord;

        }

    }
}
