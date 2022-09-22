using Microsoft.AspNetCore.Mvc.Filters;

namespace Homework_Module18.Filters
{
    public class RequestLogFilter : Attribute, IActionFilter 
    {
        private UrlLogger? _logger = new UrlLogger();
        private RequestInfo? _requestInfo = new RequestInfo();
        public void OnActionExecuted(ActionExecutedContext context)
        {
            _requestInfo.IsSuccessful = context.Exception == null;
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            _requestInfo.Url = context.HttpContext.Request.Path.ToString();
            _logger.PutRequest(context.Controller.GetType().Name, _requestInfo);
        }
    }
}
