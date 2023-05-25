using WebbApp.Models.Contexts;
using WebbApp.Models.Entities;
using WebbApp.Models.ViewModels;

namespace WebbApp.Helpers.Services
{
    public class ContactService
    {
        private readonly DataContext _context;

        public ContactService(DataContext context)
        {
            _context = context;
        }

   

        public async Task<bool> SaveContactFormAsync(ContactFormViewModel model)
        {
            try
            {
                ContactFormEntity contactEntity = model;

                _context.ContactForm.Add(contactEntity);

                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
