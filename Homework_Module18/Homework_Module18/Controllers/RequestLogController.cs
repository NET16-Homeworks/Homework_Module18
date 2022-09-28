using Microsoft.AspNetCore.Mvc;
using Homework_Module18;

namespace Homework_Module18.Controllers
{  
    public class RequestLogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("log")]
        public IActionResult GetLog()
        {
            UrlLogger urlogger = new UrlLogger();
            var requests = urlogger.GetLoggedUrls();

            return View(requests);
        }
    }
}
