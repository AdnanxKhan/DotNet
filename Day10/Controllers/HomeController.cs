using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            TempData["MyToken"] = "What is Uppppp";
            return View();
        }
          public ActionResult Index2()
        {
            Session.Abandon();
            ViewBag.MyKey = TempData.Peek("MyToken");
            //TempData.Keep("MyToken");
            return View();
        }
          public ActionResult Index3()
        {
            ViewBag.MyKey = TempData["MyToken"];
            return View();
        }

    }
}