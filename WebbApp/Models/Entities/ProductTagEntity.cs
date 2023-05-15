

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using Webbappen.Models.Entitites;

namespace WebbApp.Models.Entities
{

    [PrimaryKey("ProductId", "TagId")]
    public class ProductTagEntity
    {
        
        public int ProductId { get; set; }
        public ProductEntity Product { get; set; } = null!;

       
        public int TagId { get; set; }
        public TagEntity Tag { get; set; } = null!;
    }
}
