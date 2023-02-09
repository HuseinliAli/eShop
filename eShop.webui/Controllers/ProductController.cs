using eShop.webui.Data;
using eShop.webui.Models;
using eShop.webui.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Xml.Linq;

namespace eShop.webui.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(int? id, string? q)
        {
            var products = ProductRepository.Products;

            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }
            if(!string.IsNullOrEmpty(q))
            {
                products = products.Where(i=>i.Name.ToLower().Contains(q) || i.Description.ToLower().Contains(q)).ToList();
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

        public IActionResult Create()
        {
            var categories =new SelectList( CategoryRepository.Categories,"CategoryId", "Name");
            ViewBag.Categories = categories;
            return View(new Product());
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(product);
                return RedirectToAction("List");
            }
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            ViewBag.Categories = categories;
            return View(ProductRepository.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            ProductRepository.EditProduct(product);
            return RedirectToAction("List");
        }
    }
}
