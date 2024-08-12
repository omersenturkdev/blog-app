using BusinessLayer.Concrate;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogApp.Controllers
{
    public class BlogController : Controller
    {
		private readonly BlogManager bm;

		public BlogController(Context context)
		{
			bm = new BlogManager(new EFBlogRepository(context));
		}
		public IActionResult Index()
        {
            var values = bm.GetAllCategory();
            return View(values);
        }
    }
}
