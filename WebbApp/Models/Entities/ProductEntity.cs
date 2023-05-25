using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebbApp.Models.Dtos;
using WebbApp.Models.Entities;

namespace Webbappen.Models.Entitites;

public class ProductEntity
{


    public int Id { get; set; }


    [Required]
    public string ArticleNumber { get; set; } = null!;



    [Required]
    public string ProductName { get; set; } = null!;

    [Required]
    public string ProductDescription { get; set; } = null!;



    [Required]
    [Column(TypeName = "money")]
    public decimal Price { get; set; }


    [Required]
    public string ImageUrl { get; set; } = null!;



    [Required]
    public int CategoryId { get; set; }

    public CategoryEntity Category { get; set; } = null!;



   
    

    public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();


    public static implicit operator ProductModel(ProductEntity? entity)
    {
        return new ProductModel
        {
            Id = entity?.Id,
            ArticleNumber = entity?.ArticleNumber,
            ProductName = entity?.ProductName,
            ProductDescription = entity?.ProductDescription,
            Price = entity?.Price,
            ImageUrl = entity?.ImageUrl,
            Category = entity?.Category,
                
        };
    }


    public static implicit operator ProductTagModel(ProductEntity? entity)
    {
        return new ProductTagModel
        {
            ProductId = entity!.Id,
            ArticleNumber = entity.ArticleNumber,
            ProductName = entity.ProductName,
            ProductDescription = entity.ProductDescription,
            Price = entity.Price,
            ImageUrl = entity.ImageUrl,
            Category = entity?.Category,
           

        };
    }
}
