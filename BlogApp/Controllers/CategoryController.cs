using BusinessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryManager _categoryManager;
        public CategoryController(CategoryManager categoryManager)
        {
            _categoryManager = categoryManager;
        }
        public IActionResult Index()
        {
            var categories = _categoryManager.GetAllCategory();
            return View(categories);
        }
    }
}
