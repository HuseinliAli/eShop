using eShop.webui.Models;

namespace eShop.webui.Data
{
    public class CategoryRepository
    {
        private static List<Category> _categories = null;

        static CategoryRepository()
        {
            _categories = new List<Category>()
            {
                new Category{CategoryId=1,Name = "Phones", Description="Category of Phones"},
                new Category{CategoryId=2,Name = "TVs", Description="Category of TVs"},
                new Category{CategoryId=3,Name = "Noutbooks", Description="Category of Noutbooks"} 
            };
        }

        public static List<Category> Categories { get { return _categories; } }

        public static void AddProduct(Category category)
        {
            _categories.Add(category);
        }

        public static Category GetCategoryById(int id)
        {
            return _categories.FirstOrDefault(p => p.CategoryId == id);
        }
    }
}
