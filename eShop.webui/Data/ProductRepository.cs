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
                 new Product{ProductId = 1,Name = "Samsung",Price = 2345.5,Description = "good price", ImageUrl="1.jpg"},
                 new Product{ProductId = 2,Name = "Iphone",Price = 5434.5,Description = "good price", ImageUrl="1.jpg"},
                 new Product{ProductId = 3,Name = "Xiaomi",Price = 768.5,Description = "good price", ImageUrl = "1.jpg"},
                 new Product{ProductId = 4, Name = "Poco",Price = 567.5,Description = "good price", ImageUrl = "1.jpg"}
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
