using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    public class Student
    {


        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public static List<Student> GetAllStudents()
        {
            List<Student> list = new List<Student>();
            Student student1 = new Student
            {
                Id = 1,
                Name = "A",
                Gender = "Male",
            };
            list.Add(student1);  
            
            Student student2 = new Student
            {
                Id = 2,
                Name = "B",
                Gender = "Male",
            };
            list.Add(student2);  
                Student student3 = new Student
            {
                Id = 3,
                Name = "C",
                Gender = "Male",
            };
            list.Add(student3);  
            
            Student student4 = new Student
            {
                Id = 4,
                Name = "D",
                Gender = "Male",
            };
            list.Add(student4);  
            return list;
        }

    }
}
