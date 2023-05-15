using Microsoft.AspNetCore.Mvc;
using WebbApp.Models.Contexts;
using WebbApp.Models.Entities;

namespace WebbApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly DataContext _dataContext;

        public CategoryController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryEntity category)
        {
            if (!ModelState.IsValid)
            {
                return View(category);
            }

            _dataContext.Categories.Add(category);
            await _dataContext.SaveChangesAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}