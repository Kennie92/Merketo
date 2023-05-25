using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Entities;
using WebbApp.Models.Interfaces;

namespace WebbApp.Models.Identities;

public class AppUser : IdentityUser, IAccountInformation, ICompanyInformation, IProfileImage
{


    [Required]
    public string FirstName { get; set; } = null!;


    [Required]
    public string LastName { get; set; } = null!;
    public string? ProfileImage { get; set; }
    public string? CompanyName { get; set; }

    

    public ICollection<AccountAddressEntity> Addresses { get; set; } = new HashSet<AccountAddressEntity>();
    public ICollection<OrderEntity> Orders { get; set; } = new HashSet<OrderEntity>();
}
