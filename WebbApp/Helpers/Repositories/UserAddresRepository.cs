using WebbApp.Models.Contexts;
using WebbApp.Models.Entities;

namespace WebbApp.Helpers.Repositories
{
    public class UserAddresRepository : Repository<AccountAddressEntity>
    {
        public UserAddresRepository(IdentityContext context) : base(context)
        {
        }
    }
}
