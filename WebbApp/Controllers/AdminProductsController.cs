using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebbApp.Helpers.Services;
using Webbappen.Repositories;
using Webbappen.Services;
using Webbappen.ViewModels;

namespace Webbappen.Controllers.Admin;

[Authorize(Roles = "Admin")]
[Route("admin/products")]
public class AdminProductsController : Controller
{
    #region

    private readonly ProductService _productService;
    private readonly ProductRepository _productRepository;
    private readonly TagService _tagService;
    public AdminProductsController(ProductService productService, ProductRepository productRepository, TagService tagService)
    {
        _productService = productService;
        _productRepository = productRepository;
        _tagService = tagService;
    }

    #endregion

    [HttpGet]
    public async Task<IActionResult> Index()
    {

        return View(await _productRepository.GetAllAsync());
    }


    [HttpGet]
    [Route("new")]
    public async Task<IActionResult> New()
    {
        ViewBag.Tags = await _tagService.GetTagsAsync();
        return View();
    }


    [HttpPost]
    [Route("new")]
    public async Task<IActionResult> New(AdminProductsNewViewModel viewModel, string[] tags)
    {
        if (ModelState.IsValid)
        {
            if (await _productService.CreateAsync(viewModel))
            {
                await _productService.AddProductTagsAsync(viewModel, tags);
                return RedirectToAction("Index", "AdminProducts");

            }
            ModelState.AddModelError("", "Something went wrong!");
        }
        ViewBag.Tags = await _tagService.GetTagsAsync(tags);
        return View(viewModel);
    }



}
