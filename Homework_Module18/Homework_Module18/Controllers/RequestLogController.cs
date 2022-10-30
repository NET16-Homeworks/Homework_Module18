using Homework_Module18.Models;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Module18.Controllers
{
    public class RequestLogController : Controller
    {
        [Route("log")]
        public IActionResult GetLog()
        {
            var urlLogger = new UrlLogger();
            return View(urlLogger.GetLoggedUrls());
        }
    }
}
