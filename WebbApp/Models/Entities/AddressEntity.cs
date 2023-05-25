

using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Interfaces;

namespace WebbApp.Models.Entities;

public class AddressEntity : IAddressInformation
{
    public int Id { get; set; }

    [Required]
    public string StreetName { get; set; } = null!;

    [Required]
    public string PostalCode { get; set; } = null!;

    [Required]
    public string City { get; set; } = null!;

   
    public string? Country { get; set; }

    public ICollection<AccountAddressEntity> Accounts { get; set; } = new HashSet<AccountAddressEntity>();
}
