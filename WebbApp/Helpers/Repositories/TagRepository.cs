using WebbApp.Models.Contexts;
using WebbApp.Models.Entities;

namespace WebbApp.Helpers.Repositories;

public class TagRepository : DataRepository<TagEntity>
{
    public TagRepository(DataContext context) : base(context)
    {
    }
}
