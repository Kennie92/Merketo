using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebbApp.Helpers.Repositories;
using WebbApp.Models.Contexts;
using Webbappen.Models.Entitites;

namespace Webbappen.Repositories;

public class ProductRepository : DataRepository<ProductEntity>
{
    public ProductRepository(DataContext context) : base(context)
    {
    }
}
