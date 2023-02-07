using eShop.webui.Data;
using eShop.webui.Models;
using eShop.webui.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eShop.webui.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var productViewModel = new ProductViewModels
            {
                Products = ProductRepository.Products
            };

            return View(productViewModel);
        }

        public IActionResult About()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}