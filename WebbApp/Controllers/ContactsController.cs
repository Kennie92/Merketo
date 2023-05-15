using Microsoft.AspNetCore.Mvc;

namespace WebbApp.Controllers;

public class ContactsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
