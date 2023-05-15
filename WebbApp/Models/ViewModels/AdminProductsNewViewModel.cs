using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Entities;
using Webbappen.Models.Entitites;

namespace Webbappen.ViewModels;

public class AdminProductsNewViewModel
{
    public int Id { get; set; }

    [Display(Name = "Artikelnummer")]
    [Required(ErrorMessage = "Du måste ange ett artikelnummer")]
    public string ArticleNumber { get; set; } = null!;


    [Display(Name = "Produktens namn")]
    [Required(ErrorMessage = "Du måste ange ett produktnamn")]
    public string ProductName { get; set; } = null!;

    [Display(Name = "Produktbeskrivning")]
    [Required(ErrorMessage = "Du måste ange en produktbeskrivning")]
    public string ProductDescription { get; set; } = null!;




    [Display(Name = "Produktens Pris (SEK)")]
    [Required(ErrorMessage = "Du måste ange ett pris")]

    public decimal Price { get; set; }



    [Display(Name = "Produktbild")]
    public IFormFile ImageUrl { get; set; } = null!;



    


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
            ImageUrl = model.ImageUrl.FileName,
        };
    }



}
