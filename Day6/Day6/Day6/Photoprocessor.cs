using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public class Photoprocessor
    {
        public delegate void PhotoFilterHandler(Photo photo);
        public void Process(string path, PhotoFilterHandler filterHandler)
        {
            var photo = Photo.Load(path);
            var filters = new PhotoFilters();   

            filterHandler(photo);
            photo.Save();
        }
       
    }
}
