using System.ComponentModel.DataAnnotations;

namespace VEHCILE.Models
{
    public class Employees
    {
        [Key]
        [Required(ErrorMessage = "Please enter your EmployeeID.")]
        [RegularExpression(
            @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$
",
            ErrorMessage = "Username must start with an alphabet and can only contain letters and specialcase and numbers."
        )]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string? EmployeeID { get; set; }

        [RegularExpression(
            "^[a-zA-Z]+$",
            ErrorMessage = "The First Name should contain only alphabets."
        )]
        [Required(ErrorMessage = "Please enter your First Name.")]
        public string? Firstname { get; set; }

        [RegularExpression(
            "^[a-zA-Z]+$",
            ErrorMessage = "The Last Name should contain only alphabets."
        )]
        public string? Lastname { get; set; }

        [RegularExpression(
            "^[a-zA-Z]+$",
            ErrorMessage = "The Middle Name should contain only alphabets."
        )]
        public string? Middlename { get; set; }

        [Required(ErrorMessage = "Please select your Gender.")]
        public string? Gender { get; set; }

        [RegularExpression(@"^\+?\d{1,4}[-.\s]?\d{1,3}[-.\s]?\d{1,4}$", ErrorMessage = "Invalid Phone format.")]
        [Required(ErrorMessage = "Please enter your Phone number.")]
        public string? Phone { get; set; }

        [Required(ErrorMessage = "Please enter your Department.")]
        public string? Department { get; set; }
         [Required(ErrorMessage = "Please enter the Current Address.")]

        public string? CurrentAddress { get; set; }

        [Required(ErrorMessage = "Please enter a Password.")]
        [StringLength(
            20,
            MinimumLength = 5,
            ErrorMessage = "Password length should be between 8 and 20 characters."
        )]
        public string? Password { get; set; }
        [Compare("Password",ErrorMessage ="Password do not match.")]
        public string ConfirmPassword{get;set;}
    }
}
