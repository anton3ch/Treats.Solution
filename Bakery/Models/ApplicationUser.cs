using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Bakery.Models
{
    public class ApplicationUser : IdentityUser
    {
    [Required]
    [RegularExpression("^[a-zA-Z .]+$", ErrorMessage = "Invalid Name")]
    public string FirstName {get;set;}
    [Required]
    [RegularExpression("^[a-zA-Z .]+$", ErrorMessage = "Invalid Name")]
    public string LastName {get;set;}
    }
}