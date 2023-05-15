using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using WebbApp.Models.Identities;
using WebbApp.Models.ViewModels;

namespace WebbApp.Helpers.Services;

public class AuthenticationService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly AddressService _addressService;
    private readonly SeedService _seedService;
    private readonly RoleManager<IdentityRole> _roleManager;

    public AuthenticationService(UserManager<AppUser> userManager, AddressService addressService, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager, SeedService seedService)
    {
        _userManager = userManager;
        _addressService = addressService;
        _signInManager = signInManager;
         _seedService = seedService;
        _roleManager = roleManager;
    }

    public async Task<bool> UserAlreadyExistsAsync(Expression<Func<AppUser, bool>> expression)
    {
        return await _userManager.Users.AnyAsync(expression);
    }

    public async Task<bool> RegisterUserAsync(AccountRegisterViewModel model)
    {
        try
        {

            await _seedService.SeedRoles();
            AppUser appUser = model;
            var roleName = "User";



            if (!await _userManager.Users.AnyAsync())
                roleName = "Admin";


           

            var result = await _userManager.CreateAsync(appUser, model.Password);
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(appUser, roleName);
                var addressEntity = await _addressService.GetOrCreateAsync(model);
                if (addressEntity != null)
                {
                    await _addressService.AddAddressAsync(appUser, addressEntity);
                }
            }
                    return true;
        }

        catch { return false; }
    }



    public async Task<bool> LoginAsync(AccountLoginViewModel model)
    {
        var appUser = await _userManager.Users.FirstOrDefaultAsync(x => x.Email == model.Email);
            if (appUser != null)
        {
            var result = await _signInManager.PasswordSignInAsync(appUser, model.Password, model.RememberMe, false);
                return result.Succeeded;
        }
            return false;
    }
}
