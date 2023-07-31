using System;
using System.Web;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace VEHCILE.Models
{
    public class Employees
    {
        [Key]
        [Required(ErrorMessage = "Name is Required.")]
        public string? EmployeeID { get; set; }
        [RegularExpression("^[a-zA-z]+$", ErrorMessage = "The Customer Name should contain only alphabets")]
        [Required]
        public string? Firstname { get; set; }
        [Required]
        public string? Department { get; set; }
        public string? Middlename { get; set; }
        public string? Lastname { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }

        public string? CurrentAddress { get; set; }

        public string? Password { get; set; }

    }
}

