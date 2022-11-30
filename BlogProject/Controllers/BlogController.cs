using Business.Concrete;
using DataAccess.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BlogProject.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EFBlogRepository());

        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory;
            return View(values);
        }

        public IActionResult BlogReadAll(int id) // blog id sine göre action alacak ve buraya düşecek
        {
            var values = bm.GetBlogByID(id);
            return View();
        } 

    }
}
