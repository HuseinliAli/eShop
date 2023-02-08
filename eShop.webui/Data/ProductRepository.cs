using eShop.webui.Models;

namespace eShop.webui.Data
{
    public static class ProductRepository
    {
        private static List<Product> _products = null;

        static ProductRepository()
        {
            _products = new List<Product>()
            {
                 new Product{ProductId = 1,CategoryId=2,Name = "Samsung",Price = 2345.5,Description = "good price", ImageUrl="3.jpg"},
                 new Product{ProductId = 2,CategoryId=2,Name = "Iphone",Price = 5434.5,Description = "good price", ImageUrl="1.jpg"},
                 new Product{ProductId = 3,CategoryId=2,Name = "Xiaomi",Price = 768.5,Description = "good price", ImageUrl = "1.jpg"},
                 new Product{ProductId = 4,CategoryId=2,Name = "Poco",Price = 567.5,Description = "good price", ImageUrl = "1.jpg"},
                 new Product{ProductId = 5,CategoryId=1,Name = "Victus",Price = 2345.5,Description = "good price", ImageUrl="2.jpg"},
                 new Product{ProductId = 6,CategoryId=1,Name = "Dell",Price = 5434.5,Description = "good price", ImageUrl="3.jpg"},
                 new Product{ProductId = 7,CategoryId=1,Name = "Asus",Price = 768.5,Description = "good price", ImageUrl = "2.jpg"},
                 new Product{ProductId = 8,CategoryId=1,Name = "HP",Price = 567.5,Description = "good price", ImageUrl = "2.jpg"}
            };
        }

        public static List<Product> Products { get { return _products; } }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}
