using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using Webbappen.Models.Entitites;

namespace WebbApp.Models.Dtos
{
    public class ProductTagModel
    {
        public int? ProductId { get; set; }

        public int? TagId { get; set; }



        public string ArticleNumber { get; set; } = null!;




        public string? ProductName { get; set; } = null!;


        public string? ProductDescription { get; set; } = null!;


        public decimal? Price { get; set; }



        public string? ImageUrl { get; set; } = null!;



        


        public CategoryModel Category { get; set; } = null!;

        
    }
}
