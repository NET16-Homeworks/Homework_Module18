using Homework_Module18.Classes;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Homework_Module18.Filters
{
    public class RequestLogFilter : Attribute, IActionFilter
    {
        private UrlLogger _logger = new UrlLogger();
        private RequestInfo _requestInfo = new RequestInfo();

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if(context.Exception == null)
            {
                _requestInfo.IsSuccessful = true;
            }
            else
            {
                _requestInfo.IsSuccessful = false;
            }
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
            var controllerName = context.Controller.ToString();
            _requestInfo.Url = context.HttpContext.Request.Path.ToString();

            _logger.PutRequest(controllerName, _requestInfo);
        }
    }
}
