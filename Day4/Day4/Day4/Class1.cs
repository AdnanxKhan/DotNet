using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Class1
    {
        public static int CountWords(string text)
        {

            string[] words = text.Split(new char[] { ' ', '\t', '\n', 'r' });
            return words.Length;
        }
    }
}
