using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
public class LoginEmployee
{
    [Required(ErrorMessage = "Please enter your EmployeeID.")]
    [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9]*$", ErrorMessage = "Username must start with an alphabet and can only contain letters and numbers.")]
    public string? EmployeeID { get; set; }

    [Required(ErrorMessage = "Please enter your password.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$", ErrorMessage = "Password must be at least 8 characters and contain at least one uppercase letter, one lowercase letter, and one number.")]
    public string? Password { get; set; }

    [Required(ErrorMessage = "Last Password is required.")]
    public string LastPassword { get; set; }

    [Required(ErrorMessage = "Employee Name is required.")]
    public string EmployeeName { get; set; }

    [Required(ErrorMessage = "DOB is required.")]
    public DateTime DOB { get; set; }

    [Required(ErrorMessage = "Department is required.")]
    public string Department { get; set; }

    [Required(ErrorMessage = "Country is required.")]
    public string Country { get; set; }

    [Required(ErrorMessage = "Address is required.")]
    public string Address { get; set; }
}