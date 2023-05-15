using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace WebbApp.Models.Identities;

public class CustomClaimsPrincipalFactory : UserClaimsPrincipalFactory<AppUser>
{
    private readonly UserManager<AppUser> userManager;

    public CustomClaimsPrincipalFactory(UserManager<AppUser> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
    {
        this.userManager = userManager;
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(AppUser user)
    {
       

        var claimsIdentity = await base.GenerateClaimsAsync(user);

        claimsIdentity.AddClaim(new Claim("DisplayName", $"{user.FirstName} {user.LastName}"));


        var roles = await UserManager.GetRolesAsync(user);
        claimsIdentity.AddClaims(roles.Select(x => new Claim(ClaimTypes.Role, x)));

        return claimsIdentity;


    }



   

}
