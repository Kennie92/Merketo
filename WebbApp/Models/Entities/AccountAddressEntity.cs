using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using WebbApp.Models.Identities;

namespace WebbApp.Models.Entities;

[PrimaryKey(nameof(UserId), nameof(AddressId))]
public class AccountAddressEntity
{
    [ForeignKey(nameof(User))]
    public string UserId { get; set; } = null!;
    public AppUser User { get; set; } = null!;

    [ForeignKey(nameof(Address))]
    public int AddressId { get; set; }
    public AddressEntity Address { get; set; } = null!;
}
