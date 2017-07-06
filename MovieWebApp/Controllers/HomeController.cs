using System.Web.Mvc;

namespace MovieWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Shell()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
