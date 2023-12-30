using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NewApp.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [StringLength(255)]
        [DisplayName("Customer Name: ")]
        [Required(ErrorMessage = "Please Enter Customer Name")]
        public string CustomerName { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }

        public MembershipType MembershipTypes { get; set; }

        public byte MembershipTypeId { get; set; }
       
        public DateTime? BirthDate { get; set; }

        public List<Customer> customer { get; set; }
    }
}