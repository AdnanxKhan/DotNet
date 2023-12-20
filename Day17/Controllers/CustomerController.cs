    using MyApp.Models;
    using MyApp.ViewModels;
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
                List<Customer> customerList = _context.Customers.Include(c=>c.MembershipTypes).ToList();
                //var customer = new Customer();  

                return View(customerList);
            }
            public ActionResult Details(int id) 
            {
                Customer customer = _context.Customers.Include(c=>c.MembershipTypes).SingleOrDefault(c => c.CustomerId == id);

                return View(customer);
            }
        public ActionResult New()
        {

            var membershipTypes = _context.MembershipTypes.ToList();
            var viewmodel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewmodel);
        }
        public ActionResult Create()
        {

            var membershipTypes = _context.MembershipTypes.ToList();
            var viewmodel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View(viewmodel);
        }
       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
            {
            if(!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                { Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                
                };
                return View("Create",viewModel);
            }

              _context.Customers.Add(customer);
                _context.SaveChanges();

             return RedirectToAction("Index", "Customer");
              }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);
             if (customer == null)
                    return HttpNotFound();
            var viewModel = new CustomerFormViewModel
           {
                Customer = customer,
               MembershipTypes = _context.MembershipTypes.ToList()
        };
                return View("Edit", viewModel);

        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            if (viewModel.Customer.CustomerId == null)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(c=>c.CustomerId == viewModel.Customer.CustomerId);
                customerInDb.CustomerName = viewModel.Customer.CustomerName;
                customerInDb.BirthDate = viewModel.Customer.BirthDate;
                customerInDb.MembershipTypeId = viewModel.Customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = viewModel.Customer.IsSubscribedToNewsLetter;
            }
           
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }

    }
    }



