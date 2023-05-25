using Microsoft.AspNetCore.Mvc;
using WebbApp.Helpers.Services;
using WebbApp.Models.ViewModels;

namespace WebbApp.Controllers;

public class ContactsController : Controller
{

    private readonly ContactService _contactService;

    public ContactsController(ContactService contactService)
    {
        _contactService = contactService;
    }

    public IActionResult Index()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Index(ContactFormViewModel model)
    {

        if (ModelState.IsValid)
        {
            if (await _contactService.SaveContactFormAsync(model))
                return RedirectToAction("Index", "Contacts");

            ModelState.AddModelError("", "An error has occured, please try again");
        }

        return View(model);
    }
}
