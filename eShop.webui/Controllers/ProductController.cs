using eShop.webui.Data;
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

        public IActionResult List(int? id)
        {
            var products = ProductRepository.Products;

            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            var productViewModel = new ProductViewModels
            {
                Products = products,
            };

            return View(productViewModel);
        }


        public IActionResult Detail(int id)
        {
            var product = ProductRepository.GetProductById(id);
            return View(product);
        }
    }
}
