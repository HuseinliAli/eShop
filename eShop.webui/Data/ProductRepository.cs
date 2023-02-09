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
                 new Product{ProductId = 0,CategoryId=2,Name = "Samsung",Price = 2345.5,Description = "camera 24mgp", ImageUrl="3.jpg"},
                 new Product{ProductId = 1,CategoryId=2,Name = "Samsung",Price = 657,Description = "memory 256gb", ImageUrl="3.jpg"},
                 new Product{ProductId = 2,CategoryId=2,Name = "Iphone",Price = 5434.5,Description = "secure good camera", ImageUrl="1.jpg"},
                 new Product{ProductId = 3,CategoryId=2,Name = "Xiaomi",Price = 768.5,Description = "good price", ImageUrl = "1.jpg"},
                 new Product{ProductId = 4,CategoryId=2,Name = "Poco",Price = 567.5,Description = "good price", ImageUrl = "1.jpg"},
                 new Product{ProductId = 5,CategoryId=1,Name = "Victus",Price = 2345.5,Description = "good price", ImageUrl="2.jpg"},
                 new Product{ProductId = 6,CategoryId=1,Name = "Dell",Price = 5434.5,Description = "good price", ImageUrl="3.jpg"},
                 new Product{ProductId = 7,CategoryId=1,Name = "Asus XC415",Price = 768.5,Description = "good price", ImageUrl = "2.jpg"},
                 new Product{ProductId = 8,CategoryId=1,Name = "HP",Price = 567.5,Description = "good price", ImageUrl = "2.jpg"},
                 new Product{ProductId = 9,CategoryId=1,Name = "Asus TUF",Price = 1768.5,Description = "price is good for performance", ImageUrl = "2.jpg"}
            };
        }

        public static List<Product> Products { get { return _products; } }

        public static void AddProduct(Product product)
        {
            _products.Add(product);
        }

        public static void EditProduct(Product product)
        {
            Product updatedProduct = _products.First(p=>p.ProductId == product.ProductId);
            updatedProduct.Name = product.Name;
            updatedProduct.Price = product.Price;
            updatedProduct.Description = product.Description;
            updatedProduct.ImageUrl = product.ImageUrl;
            updatedProduct.CategoryId = product.CategoryId;
        }

        public static Product GetProductById(int id)
        {
            return _products.First(p => p.ProductId == id);
        }
    }
}
