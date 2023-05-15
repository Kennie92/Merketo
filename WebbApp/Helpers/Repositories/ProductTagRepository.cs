using WebbApp.Models.Contexts;
using WebbApp.Models.Entities;

namespace WebbApp.Helpers.Repositories
{
    public class ProductTagRepository : DataRepository<ProductTagEntity>
    {
        public ProductTagRepository(DataContext context) : base(context)
        {
        }
    }
}
