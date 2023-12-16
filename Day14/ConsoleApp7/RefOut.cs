using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class RefOut
    {
         int x = 1;
        public void RefOutM(ref int x,out int y)
        {
            x = x + 40;
            y = 50;
        }
    }
}
