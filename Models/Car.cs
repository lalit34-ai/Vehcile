using System.ComponentModel.DataAnnotations;
using System.Web;
using System;
using System.Linq;
using System.Collections.Generic;

namespace VEHCILE.Models
{
    public class Car     //to add new car
    {
        
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        [Required]
        public string? CarType { get; set; }
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        [Required]
        public string? FuelType { get; set; }
        [Required]
        public int? SeatingCapacity { get; set; }
        [Key]
        public string? CarNumber { get; set; }

        public string? Date { get; set; }=(DateTime.Now).ToString();
        public string? PickUp { get; set; }
        public string? DropOff { get; set; }

    }
}