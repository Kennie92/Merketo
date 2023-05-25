using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Entities;
using Webbappen.Models.Entitites;

namespace Webbappen.ViewModels;

public class AdminProductsNewViewModel
{
    public int Id { get; set; }

    [Display(Name = "Article Number")]
    [Required(ErrorMessage = "You must enter a article number")]
    public string ArticleNumber { get; set; } = null!;


    [Display(Name = "Product name")]
    [Required(ErrorMessage = "You must enter a product name")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Product description")]
    [Required(ErrorMessage = "You must enter a product description")]
    public string ProductDescription { get; set; } = null!;




    [Display(Name = "Product price ($)")]
    [Required(ErrorMessage = "You must enter a price for the product")]

    public decimal Price { get; set; }



    [Display(Name = "Product image")]
    [Required(ErrorMessage = "You must add a image for the product")]
    public string ImageUrl { get; set; } = null!;





    [Display(Name = "Category")]
    [Required(ErrorMessage = "You must choose a category")]
    public int CategoryId { get; set; }

  


    public static implicit operator ProductEntity(AdminProductsNewViewModel model)
    {
        return new ProductEntity
        {
            Id = model.Id,
            ArticleNumber = model.ArticleNumber,
            ProductName = model.ProductName,
            ProductDescription = model.ProductDescription,
            Price = model.Price,
            CategoryId = model.CategoryId,
            ImageUrl = model.ImageUrl,
        };
    }



}
