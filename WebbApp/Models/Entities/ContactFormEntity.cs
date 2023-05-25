using System.ComponentModel.DataAnnotations;

namespace WebbApp.Models.Entities
{
    public class ContactFormEntity
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        [Required]
        public string Email { get; set; } = null!;

        public string? PhoneNumber { get; set; }

        public string? CompanyName { get; set; }

        [Required]
        public string ContactMessage { get; set;} = null!;

        public bool SaveInfo { get; set; }

    }
}
