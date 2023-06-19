using System.ComponentModel.DataAnnotations;
using System.Web;
using System;
using System.Linq;
using System.Collections.Generic;

namespace VEHCILE.Models
{
    public class Bike
    {   [Display(Name ="Name")]
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        [Required(ErrorMessage ="Name is Required.")]
        [StringLength(12,ErrorMessage ="Name Length Exceeded")]
        public string? Name { get; set; } // BikeType
        [Key]
        public string? BikeNumber { get; set; }
        [Required]
        public int? SeatingCapacity { get; set; }
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        [Required]
        public string? FuelType { get; set; }
        [Required]
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        public string? PickUp { get; set; }
        [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
        [Required]
        public string? DropOff { get; set; }

        public string? Date { get; set; }=(DateTime.Now).ToString();

    }
}
