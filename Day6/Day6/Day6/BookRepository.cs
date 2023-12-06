using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public partial class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>

            {
                new Book() { Title ="Title 1", Price = 3},
                new Book() { Title ="Title 1", Price = 13},
                new Book() { Title ="Title 1", Price = 30}
            };
        }


    }
}
