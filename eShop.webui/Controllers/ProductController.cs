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

        public IActionResult List()
        {
            var productViewModel = new ProductViewModels
            {
                Products = ProductRepository.Products,
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
