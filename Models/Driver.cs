using System;
using System.ComponentModel.DataAnnotations;

namespace VEHCILE.Models
{
    public class Driver
    {
        [Key]
        public string EmployeeID { get; set; }

        [Required(ErrorMessage = "Please enter the driver's name.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "The Name should contain only alphabets.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the driver's phone number.")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Phone number should contain 10 digits.")]
        public string PhoneNumber { get; set; }

        public IFormFile DriverLicense { get; set; }

        public int TransReqID { get; set; }

        public int DriverUserId { get; set; }

        public int VehcileTypeId { get; set; }

        public int VehcileAddonId { get; set; }

        public string Pickup { get; set; }

        public string url { get; set; }

        [Required(ErrorMessage = "Please enter the number of available seats.")]
        [Range(
            0,
            int.MaxValue,
            ErrorMessage = "The number of available seats must be a non-negative value."
        )]
        public int AvailableSeats { get; set; }
    }
}
