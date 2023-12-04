using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Class4
    {

        public class PresentationObject
        {
            public int width { get; set; }
            public int height { get; set; }

            public void Copy()
            {
                Console.WriteLine("Copied");
            }
            public void Duplicate()
            {

                Console.WriteLine("Duplicated");
            }
        }


        }
    }
