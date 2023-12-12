using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Day11.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="First Name is required...")]
        [AdnanValidation(ErrorMessage ="Adnan is not in the name.....")]
        public string FirstName {  get; set; }
        [Required(ErrorMessage = "Last Name is required...")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Email is required...")]
        [EmailAddress]
        public string Email { get; set; }
        [Required(ErrorMessage = "Age is required...")]
        [Range(18,100)]
        public int Age { get; set; }
    }
}