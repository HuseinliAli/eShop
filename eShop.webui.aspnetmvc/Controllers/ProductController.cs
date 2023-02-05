using eShop.webui.aspnetmvc.Models;
using eShop.webui.aspnetmvc.Views.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace eShop.webui.aspnetmvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Name = "ali huseynli";

            var products = new List<Product>()
            {
                new Product{ Name= "HP 14", Description = "ChromeBook intel i3-11", Price=299.8m, ImageUrl = "https://i5.walmartimages.com/asr/ed810586-33b7-4033-942a-26aee52394a1_2.855b4fdc099f85992b7d2a16d1444d38.jpeg?odnHeight=2000&odnWidth=2000&odnBg=FFFFFF" },
                new Product{ Name= "ASUS 14", Description = "ChromeBook intel i3-11", Price=299.8m, ImageUrl = "https://i5.walmartimages.com/asr/ed810586-33b7-4033-942a-26aee52394a1_2.855b4fdc099f85992b7d2a16d1444d38.jpeg?odnHeight=2000&odnWidth=2000&odnBg=FFFFFF" },
                new Product{ Name= "MACBOOK 14", Description = "ChromeBook intel i3-11", Price=299.8m, ImageUrl = "https://i5.walmartimages.com/asr/ed810586-33b7-4033-942a-26aee52394a1_2.855b4fdc099f85992b7d2a16d1444d38.jpeg?odnHeight=2000&odnWidth=2000&odnBg=FFFFFF" },
            };
            var viewmodel = new ProductViewModel()
            {
                Products = products
            };
            return View(viewmodel);
        }
    }
}
