using System.ComponentModel.DataAnnotations;
using System.Web;
using System;
using System.Linq;
using System.Collections.Generic;
namespace VEHCILE.Models
{
    public class Driver
    {   [Key]
        public string? EmployeeID { get; set; }
        [Required]
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        public string? Name { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }

        public IFormFile? DriverLicense { get; set; }
        public string? url { get; set; }

    }
}