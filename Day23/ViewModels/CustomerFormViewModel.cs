using NewApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
        public Movie Movie { get; set; }
    }
}