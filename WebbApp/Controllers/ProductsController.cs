using Microsoft.AspNetCore.Mvc;
using WebbApp.Models.Contexts;
using Webbappen.Services;

namespace WebbApp.Controllers;

public class ProductsController : Controller
{

    private readonly DataContext _context;
    private readonly ProductService _productService;

    public ProductsController(ProductService productService, DataContext context)
    {
        _productService = productService;
        _context = context;
    }


    public IActionResult Index()
    {
        return View();
    }


    [Route("details/{id}")]
    public async Task<IActionResult> Details(int id)
    {
        var product = await _productService.GetProductDetailsAsync(id);
        return View(product);
    }
   
}
