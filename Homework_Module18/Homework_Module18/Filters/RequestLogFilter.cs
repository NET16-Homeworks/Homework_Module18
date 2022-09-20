using Homework_Module18.RequestClasses;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Homework_Module18.Filters
{
    public class RequestLogFilter : Attribute, IActionFilter
    {
        public UrlLogger urlLogger = new UrlLogger();
        public RequestInfo requestInfo = new RequestInfo();

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception != null)
            {
                requestInfo.IsSuccessful = false;
            }
            else
            {
                requestInfo.IsSuccessful = true;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            requestInfo.Url = context.HttpContext.Request.Path.ToString();
            urlLogger.PutRequest(context.Controller.GetType().Name, requestInfo);
        }
    }
}
