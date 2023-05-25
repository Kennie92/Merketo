using Microsoft.EntityFrameworkCore;
using WebbApp.Models.Entities;
using Webbappen.Models.Entitites;

namespace WebbApp.Models.Contexts;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<ProductEntity> Products { get; set; }
    public DbSet<TagEntity> Tags { get; set; }
 
    public DbSet<ProductTagEntity> ProductTags { get; set; }
    public DbSet<CategoryEntity> Categories { get; set; }

    public DbSet<ContactFormEntity> ContactForm { get; set; }

}
