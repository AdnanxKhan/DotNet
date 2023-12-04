using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Class5
    {
        public class Text : Class4
        {
            public string fontname { get; set; }
            public int fontsize { set; get; }

            public void HyperLink(string url)
            {
                Console.WriteLine("Added Hyperlink " +url);
            }
        }
    }
}
