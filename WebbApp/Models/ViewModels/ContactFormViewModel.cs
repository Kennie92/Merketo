using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Entities;

namespace WebbApp.Models.ViewModels
{
    public class ContactFormViewModel
    {

        public int Id { get; set; }

        
        [Display(Name = "Name *")]
        [Required(ErrorMessage = "You are required to enter a name.")]
        public string Name { get; set; } = null!;


        [Required(ErrorMessage = "You are required to enter a valid email.")]
        [Display(Name = "Email *")]
        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$", ErrorMessage = "Enter a valid email address.")]
        public string Email { get; set; } = null!;

        [Display(Name = "Phone Number (optional)")]
        public string? PhoneNumber { get; set; }


        [Display(Name = "Company Name (optional)")]
        public string? CompanyName { get; set; }


        [Required(ErrorMessage = "Please let us know the reason behind your contact request")]
        [Display(Name = "Message *")]
        public string ContactMessage { get; set; } = null!;

        [Display(Name = "Save my name, email in the this browser for the next time I comment.")]
        public bool SaveInfo { get; set; }


        public static implicit operator ContactFormEntity(ContactFormViewModel model)
        {
            var _contactEntity = new ContactFormEntity
            {
                Id = model.Id,
                Name = model.Name,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
                CompanyName = model.CompanyName,
                ContactMessage = model.ContactMessage,
                SaveInfo = model.SaveInfo,
            };

            return _contactEntity;
        }
    }
}
