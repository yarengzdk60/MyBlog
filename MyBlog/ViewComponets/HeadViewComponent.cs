using Microsoft.AspNetCore.Mvc;

namespace MyBlog.ViewComponets
{
    public class HeadViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
