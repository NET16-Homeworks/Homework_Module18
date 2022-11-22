using Microsoft.AspNetCore.Mvc;

namespace Homework_Module18.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
