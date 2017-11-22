using System.Web.Mvc;

namespace Trip.Web.Controllers
{
    public class AboutController : TripControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}