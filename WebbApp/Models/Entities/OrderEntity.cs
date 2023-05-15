using System.ComponentModel.DataAnnotations.Schema;
using WebbApp.Models.Identities;

namespace WebbApp.Models.Entities;

public class OrderEntity
{
    public int Id { get; set; }
    public string UserId { get; set; } = null!;
    public DateTime OrderDate { get; set; } = DateTime.Now;

    [Column(TypeName = "money")]
    public decimal TotalTAmount { get; set; }

    public AppUser User { get; set; } = null!;
}
