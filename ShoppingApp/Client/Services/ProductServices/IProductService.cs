using ShoppingApp.Shared;

namespace ShoppingApp.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        void LoadProducts();
    }
}
