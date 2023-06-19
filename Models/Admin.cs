public class LoginAdmin
{
    public string? EmployeeID { get; set; }

    // [RegularExpression("^[a-zA-z]+$",ErrorMessage="The Customer Name should contain only alphabets")]
    // [Required(ErrorMessage ="Name is Required.")]
    public string? Password { get; set; }
}