    using MyApp.Models;
    using MyApp.ViewModels;
using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;
using System.Web.Mvc;
using PagedList;


namespace MyApp.Controllers
    {
        public class CustomerController : Controller
        {
          private ApplicationDbContext _context;
            public CustomerController()
            {
                _context = new ApplicationDbContext(); 
            }
        public ActionResult Index(int? page, int pageSize = 10, string searchString = "")
        {
            var customers = _context.Customers.Include(c => c.MembershipTypes);

            // Filter by search string
            if (!string.IsNullOrEmpty(searchString))
            {
                customers = customers.Where(c => c.CustomerName.Contains(searchString));
            }

            // Order the results
            customers = customers.OrderBy(c => c.CustomerName); // You can change the ordering based on your needs

            // Paginate the results
            int pageNumber = (page ?? 1);
            var paginatedCustomers = customers.ToPagedList(pageNumber, pageSize);

            // Pass the paginated list and other relevant data to the view
            ViewBag.SearchString = searchString; // To keep the search string in the input field
            ViewBag.PageSize = pageSize;
            return View(paginatedCustomers);
        }

        public ActionResult Details(int id)
        {
            Customer customer = _context.Customers.Include(c => c.MembershipTypes).SingleOrDefault(c => c.CustomerId == id);

            return View(customer);
        }
        //public ActionResult New()
        //{

        //    var membershipTypes = _context.MembershipTypes.ToList();
        //    var viewmodel = new CustomerFormViewModel
        //    {
        //        MembershipTypes = membershipTypes
        //    };
        //    return View(viewmodel);
        //}
        public ActionResult Create()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("Create", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customer)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()

                };
                return View("Create", viewModel);
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


        public ActionResult Delete(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ConfirmDelete(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.CustomerId == id);

            if (customer == null)
                return HttpNotFound();

            _context.Customers.Remove(customer);
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }




    }
}



