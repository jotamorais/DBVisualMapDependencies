using System.Web.Mvc;

namespace DBVisualMapDependencies.Web.Controllers
{
    public class HomeController : DBVisualMapDependenciesControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}