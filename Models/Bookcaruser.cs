using System.ComponentModel.DataAnnotations;
namespace VEHCILE.Models;

public class Bookcaruser // this is for customerrequest for the bus
{
    [Key]
    public int BookingID { get; set; }

    // [RegularExpression("^[a-zA-z]+$", ErrorMessage = "The Product Name should contain only alphabets")]
    // public string? CarType { get; set; }
    public string? CarNumber { get; set; }

    [Display(Name = "EmployeeID")]
    [RegularExpression(
        ".+\\@.+\\..",
        ErrorMessage = "The Customer Name should contain only alphabets"
    )]
    public string? EmployeeID { get; set; }
    public string? senddate { get; set; } = (DateTime.Now).ToString();
    public int? quantity { get; set; }

    public string? status { get; set; }

    [Display(Name = "PickUp")]
    [RegularExpression(
        "^[a-zA-z]+$",
        ErrorMessage = "The PickUp Name should contain only alphabets"
    )]
    public string? PickUp { get; set; }

    [Display(Name = "DropOff")]
    [RegularExpression(
        "^[a-zA-z]+$",
        ErrorMessage = "The DropOff Name should contain only alphabets"
    )]
    public string? DropOff { get; set; }
}
