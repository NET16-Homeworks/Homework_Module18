using Homework_Module18.Classes;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Homework_Module18.Filtres
{
    public class RequestLogFilter: Attribute, IActionFilter
    {
        public UrlLogger _urllogger = new UrlLogger();
        public RequestInfo _requestInfo = new RequestInfo();

        public void OnActionExecuted(ActionExecutedContext context)
        {
            if (context.Exception == null)
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
            _urllogger.PutRequest(context.Controller.GetType().Name, _requestInfo);
            _requestInfo.Url = context.HttpContext.Request.Path;
        }

    }
}
