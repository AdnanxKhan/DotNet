using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day11.Models;

namespace Day11.Controllers
{
    public class StudentController : Controller
    {


       
               // GET: Student
               [Route("students")]
               public ActionResult GetAllStudents()
               {
                   var students = Students();
                   return View(students);
               }
               [Route("student/{id}")]
               public ActionResult GetStudent(int id)
               {
                   var student = Students().FirstOrDefault(x => x.Id == id);
                   return View(student);
               }
               [Route("student/{id}/studentAddress")]
               public ActionResult GetStudentAddress(int id )
               {
                   var student = Students().FirstOrDefault(x => x.Id == id);
                   if (student != null)
                   {
                       var studentAddress = student.Address;
                       return View(studentAddress);
                   }
                   else
                   {
                       // Handle the case where no student is found with the specified id
                       return HttpNotFound();
                   }

               }

               private List<Student> Students()
               {
                   return new List<Student>()
                   {

                       new Student()
                       {
                           Id = 1,
                           Name = "Josh",
                           Address = new Address()
                           {
                               Address1 = "This Kansas City",
                               City = "Kansas",
                               HomeNumber = "Student1"
                           }
                       },
                        new Student()
                   {
                        Id = 2,
                           Name = "George",
                           Address = new Address()
                           {
                               Address1 = "This Berlin City",
                               City = "Berlin",
                               HomeNumber = "Student2"
                           }
                   },
                    new Student()
                   {
                        Id = 3,
                           Name = "Blake",
                           Address = new Address()
                           {
                               Address1 = "This WestVirginia City",
                               City = "WestVirginia",
                               HomeNumber = "Student3"
                           }
                   },
                     new Student()
                   {
                        Id = 4,
                           Name = "Luke",
                           Address = new Address()
                           {
                               Address1 = "This Paris City",
                               City = "Paris",
                               HomeNumber = "Student4"
                           }
                   }

                   };
               }

    }
}




