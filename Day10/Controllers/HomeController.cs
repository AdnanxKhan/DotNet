using Day10.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Day10.Models;
using System.Linq;

namespace Day10.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult GetAllStudents()
        {
            var students = Students     ();
            return View(students);
        }
        public ActionResult GetStudent(int id) 
        {
            var student = Students().FirstOrDefault(x => x.Id == id);   

            return View(student);
        }
        public ActionResult GetStudentAddress(int id)
        {
            var  studentAddress= Students().Where(x => x.Id == id).Select(x=> x.Address);
            return View();
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
                        city = "Kansas",
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
                        city = "Berlin",
                        HomeNumber = "Student2"
                    }
            },
             new Student()
            {
                 Id = 2,
                    Name = "George",
                    Address = new Address()
                    {
                        Address1 = "This Berlin City",
                        city = "Berlin",
                        HomeNumber = "Student2"
                    }
            },
              new Student()
            {
                 Id = 3,
                    Name = "Luke",
                    Address = new Address()
                    {
                        Address1 = "This Paris City",
                        city = "Paris",
                        HomeNumber = "Student3"
                    }
            },


            };
        }
        public ActionResult Edit(int id)
        {
     
            var student = Students().FirstOrDefault(x => x.Id == id);

         
            if (student == null)
            { 
                return HttpNotFound();
            }

   
            return View(student);
        }

        [HttpPost]
        public ActionResult Edit(Student updatedStudent)
        {

            return RedirectToAction("GetAllStudents");
        }

        public ActionResult Delete(int id)
        {

            var student = Students().FirstOrDefault(x => x.Id == id);

       
            if (student == null)
            {
             
                return HttpNotFound();
            }

 
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
         
            var studentToRemove = Students().FirstOrDefault(x => x.Id == id);

            if (studentToRemove != null)
            {
                
                Students().Remove(studentToRemove);
            }

            return RedirectToAction("GetAllStudents");
        }



        //[HttpGet]
        //public ActionResult Index()
        //{


        //    return View();
        //}
        //[HttpGet]
        //public ActionResult CreateProfile()
        //{
        //    return View();
        //}
        //[HttpPut]
        //public ActionResult UpdateProfile(int id, Student student) 
        //{
        //    return View();
        //}
        //[HttpDelete]
        //public ActionResult DeleteProfile(int id)
        //{
        //    return View();
        //}
        //    {
        //    TempData["MyToken"] = "What is Uppppp";
        //    ViewBag.myCustomInput = "Lol";
        //    ViewBag.MyList=new List<string>() { "John","Mary","Joshua"};
        //    Employee employee = new Employee()
        //        {
        //            id = 1,
        //            Address = "Mumbai",
        //            Name="Adnan",
        //            isEmployee=true,
        //            DateOfBirth=new DateTime(2000,07,21)
        //        };
        //        return View(employee);
        //    }
        //    [HttpPost]
        //    public ActionResult Index(Employee employee) 
        //    {

        //        return View();
        //    }

        //    public ActionResult Edit() 
        //{
        //    return View();
        //}
        //public ActionResult Index2() 
        //{
        //    TempData["MyToken"] = "What is Uppppp";
        //    return RedirectToAction("Index2");
        //}
        //public ActionResult Index4() 
        //{
        //    ViewBag.MyKey = TempData["MyToken"];
        //    return View();
        //}
        //public ActionResult Index5() 
        //{

        //    return View();

    }
}