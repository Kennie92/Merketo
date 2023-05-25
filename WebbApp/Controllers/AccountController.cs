using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebbApp.Helpers.Services;
using WebbApp.Models.Contexts;
using WebbApp.Models.Identities;
using WebbApp.Models.ViewModels;

namespace WebbApp.Controllers;

public class AccountController : Controller
{
    private readonly DataContext _context;
    private readonly AuthenticationService _auth;
    private readonly SignInManager<AppUser> _signInManager;

    public AccountController(AuthenticationService auth, SignInManager<AppUser> signInManager, DataContext context)
    {
        _auth = auth;
        _signInManager = signInManager;
        _context = context;
    }


    #region My Account
    [Authorize]
    public IActionResult Index()
    {
        return View();
    }
    #endregion

    #region Register
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Register(AccountRegisterViewModel model)
    {

        if (model.TermsAndConditions != true)
        {
            ModelState.AddModelError("", "You must agree with the terms and conditions");
        }

      

        if (ModelState.IsValid)
        {
            if (await _auth.UserAlreadyExistsAsync(x => x.Email == model.Email))
                ModelState.AddModelError("", "An account with the same email already exists");


            if(await _auth.RegisterUserAsync(model))
            return RedirectToAction("login", "account");
        }

        return View(model);
    }
    #endregion


    #region Login

    public IActionResult Login(string ReturnUrl = null!)
    {
        var model = new AccountLoginViewModel();
        if (ReturnUrl != null)
            model.ReturnUrl = ReturnUrl;

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Login(AccountLoginViewModel model)
    {
        if (ModelState.IsValid)
        {
            if (await _auth.LoginAsync(model))
                return LocalRedirect(model.ReturnUrl);
            
            ModelState.AddModelError("", "Incorrect Email or Password");
        }
        

            
        return View(model);
    }
    #endregion

    #region Logout
    [HttpGet]
    public async Task<IActionResult> LogOut()
    {
        if (_signInManager.IsSignedIn(User))
            await _signInManager.SignOutAsync();



        return LocalRedirect("/");


    }
    #endregion
}
