using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace FlightParking.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FlightParkingControllerBase
    {
        public ActionResult Index()
        {
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}