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
            DateTime date = DateTime.Now;
            int hour = date.Hour;
            string message = hour > 12 ? "lucky days" : "good morning";
            ViewBag.Message = message;
            string username = "ali huseynli";
            ViewBag.Username = username;

            var products = new List<Product>()
            {
                 new Product{Name = "Samsung",Price = 2345.5,Description = "good price"},
                 new Product{Name = "Iphone",Price = 5434.5,Description = "good price"},
                 new Product{Name = "Xiaomi",Price = 768.5,Description = "good price"},
                 new Product{Name = "Poco",Price = 567.5,Description = "good price"}
            };

            

            var productViewModel = new ProductViewModels
            {
                Products = products
            };

            return View(productViewModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}