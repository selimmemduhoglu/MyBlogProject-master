using Microsoft.AspNetCore.Mvc;

namespace BlogProject.ViewComponents
{
    //statik bir yapı oluşturuyoruz. Viewcomponent aspnetcore.mvc ile geliyor.
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
