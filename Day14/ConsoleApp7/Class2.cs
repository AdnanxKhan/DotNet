using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Class2
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Class2()
        {
            // Default values or any initialization logic
            X = 0;
            Y = 0;
        }
        public Class2(Class2 pg)
        {

            X = pg.X;
            Y = pg.Y;
        }
    }
}
