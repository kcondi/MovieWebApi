using System.Web.Mvc;

namespace MovieWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Shell()
        {
            return View();
        }
    }
}
