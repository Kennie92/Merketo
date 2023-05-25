using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Dtos;
using Webbappen.Models.Entitites;

namespace WebbApp.Models.Entities;

public class CategoryEntity
{
    public int Id { get; set; }

    [Required]
    public string CategoryName { get; set; } = null!;


    public ICollection<ProductEntity> Products { get; set; } = new HashSet<ProductEntity>();


    public static implicit operator CategoryModel(CategoryEntity? entity)
    {
        return new CategoryModel
        {
            Id = entity?.Id,
            CategoryName = entity?.CategoryName,


        };

    }
}
