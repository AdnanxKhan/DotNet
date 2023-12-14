using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CRUDStart.Models
{
    public class Employee
    {

        [Key]
        [Required]
        [DisplayName("Employee ID: ")]
        public int ID { get; set; }
        [Required]
        [DisplayName("Employee Name: ")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Employee Department: ")]
        public string Department { get; set; }
        [Required]
        [DisplayName("Employee Salary: ")]
        public int Salary { get; set; }
    }
}