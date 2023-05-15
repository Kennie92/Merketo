using System.ComponentModel.DataAnnotations.Schema;
using WebbApp.Models.Dtos;
using WebbApp.Models.Entities;

namespace Webbappen.Models.Entitites;

public class ProductEntity
{


    public int Id { get; set; } 
    
    public string ArticleNumber { get; set; } = null!;


    

    public string ProductName { get; set; } = null!;

  
    public string ProductDescription { get; set; } = null!;

  


    [Column(TypeName = "money")]
    public decimal Price { get; set; }



    public string ImageUrl { get; set; } = null!;




    public int CategoryId { get; set; }

    public CategoryEntity Category { get; set; } = null!;


    

    public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();


    public static implicit operator ProductModel(ProductEntity? entity)
    {
        return new ProductModel
        {
            Id = entity!.Id,
            ArticleNumber = entity.ArticleNumber,
            ProductName = entity.ProductName,
            ProductDescription = entity.ProductDescription,
            Price = entity.Price,
            ImageUrl = entity.ImageUrl,
            Category = entity?.Category,
        };
    }
}
