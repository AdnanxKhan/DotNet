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
        public ActionResult Create(CustomerFormViewModel viewModel,Customer customer)
            {
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
                
                return View("Edit", customer);

        }
        [HttpPost]
        public ActionResult Edit(Customer customer)
        {
            if (customer.CustomerId == null)
                _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.SingleOrDefault(c=>c.CustomerId == customer.CustomerId);
                customerInDb.CustomerName = customer.CustomerName;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
        }

    }
    }




/*
 * 
 * 
 *   //public ActionResult Edit()
        //{
        //    var membershipTypes = _context.MembershipTypes.ToList();
        //    var viewmodel = new CustomerFormViewModel
        //    {
        //        MembershipTypes = membershipTypes
        //    };
        //    return View(viewmodel);
        //}
        //[HttpGet]
        //public ActionResult Edit(int id)
        //{
        //    var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);
        //    if (customer == null)
        //        return HttpNotFound();
        //    var viewModel = new CustomerFormViewModel
        //    {
        //        Customer = customer,
        //        MembershipTypes = _context.MembershipTypes.ToList()
        //};
        //    return View("Edit",viewModel);
        //}
        [HttpGet]
        public ActionResult Edit(int id = 0)
        {
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            if (id > 0)
            {
                var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);
                if (customer == null)
                    return HttpNotFound();

                viewModel.Customer = customer;
            }

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(CustomerFormViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.MembershipTypes = _context.MembershipTypes.ToList();
                return View(viewModel);
            }
           

            var customerInDb = _context.Customers.SingleOrDefault(c => c.CustomerId == viewModel.Customer.CustomerId);
            if (customerInDb == null)
            {
        
                return HttpNotFound(); 
            }
            customerInDb.CustomerName= viewModel.Customer.CustomerName;
                customerInDb.BirthDate= viewModel.Customer.BirthDate;
                customerInDb.MembershipTypeId= viewModel.Customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter= viewModel.Customer.IsSubscribedToNewsLetter;
            
            _context.SaveChanges();
            return RedirectToAction("Index","Customer");
 * 
 */