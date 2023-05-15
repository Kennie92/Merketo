using Microsoft.AspNetCore.Mvc;


namespace WebbApp.Controllers;


public class HomeController : Controller
{

    public IActionResult Index()
    {
        
        return View();

    }

}
