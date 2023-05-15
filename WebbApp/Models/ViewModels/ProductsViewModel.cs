using WebbApp.Models.Dtos;

namespace WebbApp.Models.ViewModels
{
    public class ProductsViewModel
    {
        public IEnumerable<ProductModel> Products { get; set; } = new List<ProductModel>();
    }
}
