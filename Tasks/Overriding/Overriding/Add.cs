using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Add
    {
        int x;
        int y;
        public static int Sum()
        {
            var sum = 0;

            return sum;
        }
       public static int Sum(int x, int y)
        {
            var sum = x+ y;
            return sum;
        }
        public double Sum (double x,double y)
        {
            double sum = x+ y;
            return sum;
        }
        public float Sum (float x,float y)
        {
            float sum = x+ y;
            return sum;
        }
    
    }


}
