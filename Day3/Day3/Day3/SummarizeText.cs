using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    internal class SummarizeText
    {
        public static string summarizeText(string text, int maxlength = 20)
        {

            if (text.Length < maxlength)
                return text;

            var words = text.Split(' ');
            var totalcharacters = 0;
            var summarywords = new List<string>();
            foreach (var word in words)
            {
                summarywords.Add(word);
                totalcharacters += word.Length + 1;
                if (totalcharacters > maxlength)
                    break;


            }
            return String.Join(" ", summarywords) + "....";

        }
    }
}
