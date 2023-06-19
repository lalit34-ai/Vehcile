using System.ComponentModel.DataAnnotations;

namespace VEHCILE.Models;

public class Bookebususer   // this is for customerrequest for the bus
{
    [Key]
    public int  BookingID{get;set;}
    [Display(Name ="Type of Bus")]
    [RegularExpression("^[a-zA-z]+$", ErrorMessage = "The Product Name should contain only alphabets")]
    public string? BusType { get; set; }
    public string? BusNumber { get; set; }

    [RegularExpression("^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$", ErrorMessage = "The Customer Name should contain only alphabets")]
    
    public string? EmployeeID { get; set; }
    public string? senddate { get; set; }=(DateTime.Now).ToString();
    public int? quantity { get; set; }

    public string? status { get; set; }

    [RegularExpression("^[a-zA-z]+$", ErrorMessage = "The Customer Name should contain only alphabets")]
    public string? PickUp { get; set; }
    [RegularExpression("^[a-zA-z]+$", ErrorMessage = "The Customer Name should contain only alphabets")]
    public string? DropOff { get; set; }
}
