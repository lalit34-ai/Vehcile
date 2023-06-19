using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VEHCILE.Models;

public class Feedback
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address.")] 
    [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov)$", ErrorMessage = "Invalid pattern.")]
    public string? emailid{get; set;}
    [Required]
    public int rating{get; set;}
    [Required]
    public string? feedback{get; set;}

}