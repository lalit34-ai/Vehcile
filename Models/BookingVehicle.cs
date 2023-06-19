using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace VEHCILE.Models
{   // for the booking from the client side
    public class BookingVehicle
    {
        public string? EmployeeID { get; set; }

        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        public string? PickUp { get; set; }
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        public string? Destination { get; set; }
        public string? Time { get; set; }
        public DateOnly Date { get; set; }
        public string? BusNumber { get; set; }
        public string? BusID { get; set; }

        public string? CarNumber { get; set; }
        public string? CarID { get; set; }
        public string? BikeId { get; set; }
        public string? BikeNumber { get; set; }

        public string? PickDate{get;set;}
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        public string? City{get; set;}
        public string? StartTime{get; set;}
        public string? EndDate{get; set;}
        public string? EndTime{get; set;}
    }
}