using Microsoft.AspNetCore.Mvc;

namespace WebbApp.Controllers;

public class DeniedController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
