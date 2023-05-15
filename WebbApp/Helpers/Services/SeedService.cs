using Microsoft.AspNetCore.Identity;

namespace WebbApp.Helpers.Services;

public class SeedService
{
    private readonly RoleManager<IdentityRole> _roleManager;
public SeedService(RoleManager<IdentityRole> roleManager)
    {
        _roleManager = roleManager;
    }

    public async Task SeedRoles()
    {
        if (!await _roleManager.RoleExistsAsync("Admin"))
            await _roleManager.CreateAsync(new IdentityRole("Admin"));

        if (!await _roleManager.RoleExistsAsync("User"))
            await _roleManager.CreateAsync(new IdentityRole("User"));
    }

}
