using MyApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace MyApp.Dtos
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        [StringLength(255)]

        [Required(ErrorMessage = "Please Enter Customer Name")]
        public string CustomerName { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }



        public byte MembershipTypeId { get; set; }
        [Min18YearsIfAMember(ErrorMessage = "Customer Should be 18 years of Age or Older.")]
        public DateTime? BirthDate { get; set; }

        public List<Customer> customer { get; set; }
    }
}