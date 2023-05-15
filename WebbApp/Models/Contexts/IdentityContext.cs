using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebbApp.Models.Entities;
using WebbApp.Models.Identities;

namespace WebbApp.Models.Contexts;

public class IdentityContext : IdentityDbContext<AppUser>
{
    public IdentityContext(DbContextOptions<IdentityContext> options) : base(options)
    {
    }



    
    public DbSet<AddressEntity> Addresses { get; set; }
    public DbSet<AccountAddressEntity> AccountAddresses { get; set; }

    public DbSet<OrderEntity> Orders { get; set; }
    public DbSet<OrderRowEntity> OrderRows { get; set; }
    public DbSet<InvoiceEntity> Invoices { get; set; }
    public DbSet<InvoiceRowEntity> InvoicesRows { get; set; }



    /*
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        var roleId = Guid.NewGuid().ToString();
        var userId = Guid.NewGuid().ToString();

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { 
                Id = roleId,
                Name = "System Administrator",
                NormalizedName = "SYSTEM ADMINISTRATOR"

                
                }
            );


        var passwordHasher = new PasswordHasher<AppUser>();

        builder.Entity<AppUser>().HasData(new AppUser
        {
            Id = userId,
            FirstName = " ",
            LastName = " ",
            UserName = "administrator@domain.com",
            Email = "adminstrator@domain.com", 
            PasswordHash = passwordHasher.HashPassword(null!, "Bytmig!123") 
        });

        builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
        {
            RoleId = roleId,
            UserId = userId,
        });
        
            }
    */
    }

