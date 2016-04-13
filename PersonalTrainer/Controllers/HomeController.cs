using System.Web.Mvc;

namespace PersonalTrainer.Controllers
{
    public class HomeController : Controller
    {
        [RequireHttps]
        public ActionResult Index()
        {
            ViewBag.Message = "Here to help you up your game";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}