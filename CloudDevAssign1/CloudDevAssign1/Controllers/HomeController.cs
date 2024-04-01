using CloudDevAssign1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CloudDevAssign1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            
            _logger = logger;
        }

        public IActionResult Index()
        {
            /*
            HomePage1 hp = new HomePage1();           
            hp.Name = "itemThing";
            hp.price = 1;
            */
            return View();
        }
        

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
        public IActionResult MyWorkPage()
        {
            return View();
        }
        public IActionResult BuyPage()
        {
            return View();
        }

        public IActionResult PurchaseComplete() 
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
