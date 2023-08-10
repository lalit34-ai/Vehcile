using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VEHCILE.Models
{
    // for the booking from the client side
    public class BookingVehicle
    {
        [Required(ErrorMessage = "EmployeeID is required.")]
        public string? EmployeeID { get; set; }

        [Required(ErrorMessage = "PickUp location is required.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "PickUp should contain only alphabets.")]
        public string? PickUp { get; set; }

        [Required(ErrorMessage = "Destination is required.")]
        [RegularExpression(
            "^[a-zA-Z]+$",
            ErrorMessage = "Destination should contain only alphabets."
        )]
        public string? Destination { get; set; }

        [Required(ErrorMessage = "Time is required.")]
        public string? Time { get; set; }

        [Required(ErrorMessage = "Date is required.")]
        public DateOnly Date { get; set; }

        public string? BusNumber { get; set; }
        public string? BusID { get; set; }
        public string? CarNumber { get; set; }
        public string? CarID { get; set; }
        public string? BikeId { get; set; }
        public string? BikeNumber { get; set; }

        [Required(ErrorMessage = "PickDate is required.")]
        public string? PickDate { get; set; }

        [Required(ErrorMessage = "City is required.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "City should contain only alphabets.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "StartTime is required.")]
        public string? StartTime { get; set; }

        [Required(ErrorMessage = "EndDate is required.")]
        public string? EndDate { get; set; }

        [Required(ErrorMessage = "EndTime is required.")]
        public string? EndTime { get; set; }
    }
}
