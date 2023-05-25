using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebbApp.Models.Entities;
using Webbappen.Repositories;
using Webbappen.Services;


namespace WebbApp.Models.Dtos;

public class ProductModel
{
   

  

    public int? Id { get; set; }

    public string? ArticleNumber { get; set; }
    public string? ProductName { get; set; }
    public string? ProductDescription { get; set; }
    public decimal? Price { get; set; }

    public string? ImageUrl { get; set; }


    public CategoryModel? Category { get; set; }


  

}

