using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class SignalRController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult F5()
        {
            return View();
        }
    }
}
