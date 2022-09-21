using Microsoft.AspNetCore.Mvc.Filters;
using Homework_Module18.Classes;

namespace Homework_Module18.Filters
{
    public class RequestLogFilter : IActionFilter
    {
        UrlLogger _urlLogger = new();
        RequestInfo _requestInfo = new();

        public void OnActionExecuted(ActionExecutedContext context)
        {
            var controller = context.Controller.GetType().Name;
            var isSuccess = context.Exception == null;

            _requestInfo.IsSuccess = isSuccess;

            _urlLogger.PutRequest(controller, _requestInfo);
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _requestInfo.Url = context.HttpContext.Request.Path.Value;
        }
    }
}
