using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebbApp.Models.Contexts;
using WebbApp.Models.Identities;
using WebbApp.Models.ViewModels;

namespace WebbApp.Controllers;

    [Authorize(Roles = "Admin")]
public class AdminController : Controller
{

    public readonly IdentityContext _identityContext;

    public AdminController(IdentityContext identityContext)
    {
        _identityContext = identityContext;
    }

    public IActionResult Index()
    {
        return View();
    }

 

}
