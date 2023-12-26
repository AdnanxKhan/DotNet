using NewApp.Models;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NewApp.Dtos
{
    public class CustomerDto
    {
        public int CustomerId { get; set; }

        [StringLength(255)]

        [Required(ErrorMessage = "Please Enter Customer Name")]
        public string CustomerName { get; set; }

        public bool IsSubscribedToNewsLetter { get; set; }



        public byte MembershipTypeId { get; set; }

        public DateTime? BirthDate { get; set; }

        public List<Customer> customer { get; set; }
    }
}