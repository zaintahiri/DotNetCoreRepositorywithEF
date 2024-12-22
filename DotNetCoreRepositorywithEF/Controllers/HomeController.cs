using Microsoft.AspNetCore.Mvc;

namespace DotNetCoreRepositorywithEF.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
