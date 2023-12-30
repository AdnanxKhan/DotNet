using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApp.Controllers
{
    public class NewRentalController : Controller
    {
        // GET: NewRentals
        public ActionResult New()
        {

            return View();
        }
    }
}