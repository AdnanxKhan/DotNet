using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day11.Models;

namespace Day11.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
     public ActionResult Index()
        {

            return View();
        }
        [HttpPost]
       public ActionResult SubmitData(Employee emp)
        {
            if (ModelState.IsValid)
            {
                return View();
            }

            return View("Index");
        }
       

    }
}




/*
  [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public string PostUsingParameters(string firstName , string lastName) 
        {

            return "FullName From Parameters : "+firstName+" "+lastName;
        }
        public string PostUsingRequest()
        {
            string firstName = Request["firstName"];
            string lastName = Request["lastName"];

            return "FullName From Request : " + firstName + " " + lastName;
        }
        public string PostUsingForm(FormCollection form)
        {
            string firstName = form["firstName"];
            string lastName = form["lastName"];

            return "FullName From Request : " + firstName + " " + lastName;
        }
        public string PostUsingBinding(Employee emp)
        {
            

            return "FullName From Request : " + emp.firstName + " " + emp.lastName;
        }

 */