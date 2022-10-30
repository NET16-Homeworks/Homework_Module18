using Homework_Module18.Models;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Homework_Module18.Filters
{
    public sealed class RequestLogFilter : Attribute, IActionFilter
    {
        private RequestInfo _requestInfo = new RequestInfo();
        private UrlLogger _urlLogger = new UrlLogger();
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _requestInfo.IsSuccessful = context.Exception == null;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = context.Controller.GetType().Name;
            _requestInfo.Url = context.HttpContext.Request.Path.ToString();
            _urlLogger.PutRequest(controller, _requestInfo);
        }
    }
}
