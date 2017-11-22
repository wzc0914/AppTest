using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace Trip.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TripControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}