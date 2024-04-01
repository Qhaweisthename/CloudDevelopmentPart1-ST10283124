using Microsoft.AspNetCore.Mvc;

namespace CloudDevAssign1.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
