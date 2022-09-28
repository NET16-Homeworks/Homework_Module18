using Microsoft.AspNetCore.Mvc;

namespace Homework_Module18.Controllers
{
    public class UrlLoggerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
