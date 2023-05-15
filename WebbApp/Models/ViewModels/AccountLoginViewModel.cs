using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Interfaces;

namespace WebbApp.Models.ViewModels;

public class AccountLoginViewModel : ILoginInformation
{
    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email is required")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set; } = null!;


    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
   
    
    [Display(Name = "Keep me logged in")]
    public bool RememberMe { get; set; }

    public string ReturnUrl { get; set; } = "/";
}
