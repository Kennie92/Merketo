using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using WebbApp.Models.Dtos;
using Webbappen.Models.Entitites;

namespace WebbApp.Models.Entities
{


   
    public class TagEntity
    {

        public int Id { get; set; }

        [Required]
        public string TagName { get; set; } = null!;

        public ICollection<ProductTagEntity> ProductTags { get; set; } = new HashSet<ProductTagEntity>();


        public static implicit operator TagModel(TagEntity? entity)
        {
            return new TagModel
            {
                Id = entity!.Id,
                TagName = entity.TagName,

            };
        }
    }
}
