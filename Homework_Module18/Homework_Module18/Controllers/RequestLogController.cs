using Homework_Module18.RequestClasses;
using Microsoft.AspNetCore.Mvc;
using Homework_Module18.Filters;

namespace Homework_Module18.Controllers
{
    public class RequestLogController : Controller
    {
        private readonly UrlLogger _urlLogger = new UrlLogger();
        [Route("log")]
        public IActionResult GetLog()
        {
            return View(_urlLogger.GetLoggedUrls());
        }
    }
}
