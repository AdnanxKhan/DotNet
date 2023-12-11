using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Day10.Models
{
    public class Employee
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool isEmployee { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
    }
}