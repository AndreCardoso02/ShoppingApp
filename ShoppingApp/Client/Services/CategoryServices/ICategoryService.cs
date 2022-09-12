using ShoppingApp.Shared;

namespace ShoppingApp.Client.Services.CategoryServices
{
    public interface ICategoryService
    {
        public List<Category> Categories { get; set; }
        void LoadCategories();
    }
}
