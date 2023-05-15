using WebbApp.Models.Contexts;
using WebbApp.Models.Entities;

namespace WebbApp.Helpers.Repositories
{
    public class AddressRepository : Repository<AddressEntity>
    {
        public AddressRepository(IdentityContext context) : base(context)
        {
        }
    }
}
