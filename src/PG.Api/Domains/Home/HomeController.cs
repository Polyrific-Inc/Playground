using System.Web.Mvc;

namespace PG.Api.Domains.Home
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
