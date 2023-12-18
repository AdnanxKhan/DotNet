using MyApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyApp.Controllers
{
    public class CustomerController : Controller
    {
      private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext(); 
        }
        public ActionResult Index()
        {
            List<Customer> customerList = _context.Customers.ToList();
            //var customer = new Customer();  

            return View(customerList);
        }
    }
}