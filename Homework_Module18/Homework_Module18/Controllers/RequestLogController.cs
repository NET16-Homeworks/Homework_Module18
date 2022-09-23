using Microsoft.AspNetCore.Mvc;
using Homework_Module18.LogService;
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
            UrlLogger urlLogger = new UrlLogger();
            return View(urlLogger.GetLoggedUrls());
        }

    }
}
