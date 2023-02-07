using eShop.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.webui.ViewComponents
{
    public class CategoriesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()
            {
                new Category{Name = "Phones", Description="Category of Phones"},
                new Category{Name = "TVs", Description="Category of TVs"},
                new Category{Name = "Noutbooks", Description="Category of Noutbooks"},
            };
            return View(categories);
        }
    }
}
