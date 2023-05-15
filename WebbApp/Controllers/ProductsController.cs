using Microsoft.AspNetCore.Mvc;
using WebbApp.Models.Dtos;
using WebbApp.Models.ViewModels;
using Webbappen.Services;

namespace WebbApp.Controllers;

public class ProductsController : Controller
{
   
    private readonly ProductService _productService;

    public ProductsController(ProductService productService)
    {
        _productService = productService;
    }

   
    public IActionResult Index()
    {
        return View();
    }


[Route("details/{id}")]
    public IActionResult Details(int Id)
    {
        return View();
    }
}
