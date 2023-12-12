using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Day11
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();
            //routes.MapRoute(
            //    name:"allStudents",
            //    url: "students",
            //    defaults: new { controller = "Student", action="GetAllStudents", id = UrlParameter.Optional }
            //    );
            //routes.MapRoute(
            //  name: "Student",
            //  url: "students/{id}",
            //  defaults: new { controller = "Student", action = "GetStudent", id = UrlParameter.Optional }
            //  );

            //routes.MapRoute(
            //  name: "StudentAddress",
            //  url: "students/{id}/Address",
            //  defaults: new { controller = "Student", action = "GetStudentAddress", id = UrlParameter.Optional }
            //  );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
