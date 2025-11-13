using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Models;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }
    }
}
