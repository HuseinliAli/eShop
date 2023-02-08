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
            if (RouteData.Values["action"].ToString()=="List")
            {
                ViewBag.SelectedCategory = RouteData?.Values["id"];
            }
            
            return View(categories);
        }
    }
}
