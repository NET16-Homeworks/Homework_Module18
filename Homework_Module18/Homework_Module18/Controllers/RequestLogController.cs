using Homework_Module18.Classes;
using Homework_Module18.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Homework_Module18.Controllers
{
    [RequestLogFilter]
    public class RequestLogController : Controller
    {
        private readonly ILogger<RequestLogController> _logger;

        public RequestLogController(ILogger<RequestLogController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("RequestLog/log")]
        public IActionResult GetLog()
        {
            UrlLogger logger = new UrlLogger();
            var listOfLoggerInformation = logger.GetLoggedUrls();
            return View(listOfLoggerInformation);
        }
    }
}
