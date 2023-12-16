using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp7
{
    public class Numerable : IEnumerable<int>
    {
        private List<int> items = new List<int>();
        public IEnumerator<int> GetEnumerator()
        {
            return items.GetEnumerator();
        }
            
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        public void AddItem(int item)
        {
            items.Add(item);
        }
    }
}

