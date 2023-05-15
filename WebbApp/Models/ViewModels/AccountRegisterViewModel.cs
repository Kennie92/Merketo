

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Entities;
using WebbApp.Models.Identities;
using WebbApp.Models.Interfaces;

namespace WebbApp.Models.ViewModels;

public class AccountRegisterViewModel : IAccountRegistration
{
    [Display(Name = "First Name")]
    [Required(ErrorMessage = "First name is required")]
    public string FirstName { get; set; } = null!;


    [Display(Name = "Last Name")]
    [Required(ErrorMessage = "Last name is required")]
    public string LastName { get; set; } = null!;


   


    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email is required")]
    [DataType(DataType.EmailAddress)]
    [RegularExpression(@"^([0-9a-zA-Z]([\+\-_\.][0-9a-zA-Z]+)*)+@(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]*\.)+[a-zA-Z0-9]{2,3})$", ErrorMessage = "Your email address is not in a valid format. Example of correct format: joe.example@example.org")]
    public string Email { get; set; } = null!;


    [Display(Name = "Phone Number(Optional)")]
    [DataType(DataType.PhoneNumber)]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Company Name(Optional)")]
    public string? CompanyName { get; set; }

    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password is required")]
    [DataType(DataType.Password)]
    [RegularExpression("^(?=.*[a-ö])(?=.*[A-Ö])(?=.*\\d)(?=.*[!@#$^&*])[A-Öa-ö\\d!@#$%^&*]{8,}$", ErrorMessage = "Passwords must be at least 8 characters and contain at 3 of 4 of the following: upper case (A-Z), lower case (a-z), number (0-9) and special character (e.g. !@#$%^&*)")]
    public string Password { get; set; } = null!;


    [Display(Name = "Confirm Password")]
    [Required(ErrorMessage = "Password does not match")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;


    [Display(Name = "Street Name")]
    [Required(ErrorMessage = "Street name is required")]
    public string StreetName { get; set; } = null!;

    [Display(Name = "Postal Code")]
    [Required(ErrorMessage = "Postal code is required")]
    [DataType(DataType.PostalCode)]
    public string PostalCode { get; set; } = null!;

    [Display(Name = "City")]
    [Required(ErrorMessage = "City is required")]
    public string City { get; set; } = null!;

    [Display(Name = "Country")]
    public string? Country { get; set; }

    [Display(Name = "Profile Image(Optional)")]
    [DataType(DataType.Upload)]
    public IFormFile? ProfileImage { get; set; }

    [Display(Name = "I have read and accept the terms and agreements")]
    [Required(ErrorMessage = "You must agree to the terms and conditions")]
    public bool TermsAndConditions { get; set; } = false;


   

    public static implicit operator AppUser(AccountRegisterViewModel model)
    {
        return new AppUser
           {
               UserName = model.Email,
               FirstName = model.FirstName,
               LastName = model.LastName,
               Email = model.Email,
               PhoneNumber = model.PhoneNumber,
               CompanyName = model.CompanyName,
           };
    }

    public static implicit operator AddressEntity(AccountRegisterViewModel model)
    {
        return new AddressEntity
        {
            StreetName = model.StreetName,
            PostalCode  = model.PostalCode,
            City = model.City,
        };
    }
}
