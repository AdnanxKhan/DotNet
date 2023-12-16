    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using WebApplication10.Models;

    namespace WebApplication10.ViewModels
    {
        public class RandomViewModel
        {
            public Movie Movie { get; set; }
        
            public List<Customer> Customers { get; set; }

        }
    }