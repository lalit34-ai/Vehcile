using System;
using System.ComponentModel.DataAnnotations;

namespace VEHCILE.Models
{
    public class DBFacilities
    {
        [Key]
        [Required(ErrorMessage = "Please enter the EmployeeID.")]
        public string? EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter the Employee's Name.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The Employee Name should contain only alphabets.")]
        public string? EmployeeName { get; set; }

        [Required(ErrorMessage = "Please enter the Department.")]
        public string? Department { get; set; }

        [Required(ErrorMessage = "Please enter the Vehicle Type.")]
        public string? Vehicle_type { get; set; }
    }
}
