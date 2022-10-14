using Microsoft.AspNetCore.Mvc;
using Homework_Module18.Classes;

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
            UrlLogger urllogger = new();

            return View(urllogger.GetLoggedUrls());
        }


    }
}
