using System.ComponentModel.DataAnnotations;
using System.Web;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace VEHCILE.Models
{
    public class Bus
    {
        [RegularExpression("^[a-zA-z]+$", ErrorMessage = "The Customer Name should contain only alphabets")]
        [Required]
        public string? BusType { get; set; }
        [Key]
        public string? BusNumber { get; set; }
        [Required]
        public int? SeatingCapacity { get; set; }
        [Required]
        public string? FuelType { get; set; }
        [RegularExpression("^[a-zA-z]+$", ErrorMessage = "The Customer Name should contain only alphabets")]
        public string? PickUp { get; set; }
        [RegularExpression("^[a-zA-z]+$", ErrorMessage = "The Customer Name should contain only alphabets")]
        public string? DropOff { get; set; }
        public string? Date { get; set; }=(DateTime.Now).ToString();
    }

}