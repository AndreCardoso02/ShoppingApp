using ShoppingApp.Shared;

namespace ShoppingApp.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public void LoadProducts()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    Price = 8.19m,
                    OriginalPrice = 29.99m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 1,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    Price = 166.66m,
                    OriginalPrice = 249.00m
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Pentax Spotmatic",
                    Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., lat",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                    Price = 159.99m,
                    OriginalPrice = 299.9m
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    Price = 276m,
                    OriginalPrice = 199.9m
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 2,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo ENtertainment System (SNESS), also known as the super NES or Super Nintendo, is a 16-bit home video game",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    Price = 73.74m,
                    OriginalPrice = 400m
                }
            };
        }
    }
}
