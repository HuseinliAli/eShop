using eShop.webui.Models;
using eShop.webui.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace eShop.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List()
        {
            var products = new List<Product>()
            {
                 new Product{Name = "Samsung",Price = 2345.5,Description = "good price"},
                 new Product{Name = "Iphone",Price = 5434.5,Description = "good price"},
                 new Product{Name = "Xiaomi",Price = 768.5,Description = "good price"},
                 new Product{Name = "Poco",Price = 567.5,Description = "good price"}
            };

            var categories = new List<Category>()
            {
                new Category{Name = "Phones", Description="Category of Phones"},
                new Category{Name = "TVs", Description="Category of TVs"},
                new Category{Name = "Noutbooks", Description="Category of Noutbooks"},
            };

            var productViewModel = new ProductViewModels
            {
                Products = products,
                Categories = categories
            };

            return View(productViewModel);
        }


        public IActionResult Detail(int id)
        {
            var product = new Product()
            {
                Name = "SAMSUNG",
                Price = 2345.5,
                Description = "good price"
            };
            return View(product);
        }

    }
}
