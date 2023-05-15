using System.ComponentModel.DataAnnotations.Schema;

namespace WebbApp.Models.Entities;

public class InvoiceEntity
{
    public int Id { get; set; }
    public string? UserId { get; set; }
    public string CustomerFullName { get; set; } = null!;
    public string? CustomerFullAddress { get; set; }
    public int? OrderId { get; set; }
    public DateTime InvoiceDate { get; set; } = DateTime.Now;
    public DateTime DueDate { get; set; } = DateTime.Now.AddDays(30);

    [Column(TypeName = "money")]
    public decimal TotalTAmount { get; set; }

    [Column(TypeName = "money")]
    public decimal TotalTaxAmount { get; set; }
}
