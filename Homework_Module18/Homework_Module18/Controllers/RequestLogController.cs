using Microsoft.AspNetCore.Mvc;
using Homework_Module18.Classes;

namespace Homework_Module18.Controllers
{
    public class RequestLogController : Controller
    {
        public IActionResult Index()
        {
            return Redirect("GetLog");
        }
        [Route("log")]
        public IActionResult GetLog()
        {
            UrlLogger logger = new();

            return View(logger.GetLoggedUrls());
        }
    }
}
