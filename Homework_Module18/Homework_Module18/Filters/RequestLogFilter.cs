using Microsoft.AspNetCore.Mvc.Filters;
using Homework_Module18;

namespace Homework_Module18.Filters
{
    public class RequestLogFilter : Attribute,IActionFilter
    {
        private UrlLogger _urllogger = new UrlLogger();
        private RequestInfo _requestInfo = new RequestInfo();

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (_requestInfo.isSuccessful)
            {
                if (context.Exception != null)
                    {
                        _requestInfo.isSuccessful = true;
                        Console.WriteLine("Requst is successful");
                    }
            }

            else
            {
                _requestInfo.isSuccessful = false;
                Console.WriteLine("Request cannot be completed");
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _urllogger.PutRequest(context.Controller.GetType().Name, _requestInfo);
            _requestInfo.Url = context.HttpContext.Request.Path;
        }
    }
}
