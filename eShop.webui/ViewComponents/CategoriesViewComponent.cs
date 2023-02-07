using eShop.webui.Data;
using eShop.webui.Models;
using Microsoft.AspNetCore.Mvc;

namespace eShop.webui.ViewComponents
{
    public class CategoriesViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = CategoryRepository.Categories;
            return View(categories);
        }
    }
}
