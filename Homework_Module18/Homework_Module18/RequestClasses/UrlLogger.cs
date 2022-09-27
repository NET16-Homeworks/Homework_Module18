using Homework_Module18.Filters;
namespace Homework_Module18.RequestClasses
{
    public class UrlLogger
    {
        private static Dictionary<string, List<RequestInfo>> _loggedRequests = new Dictionary<string, List<RequestInfo>>();
        public List<string> GetLoggedUrls()
        {
            List<string> loggedUrls = new List<string>();
            foreach (var request in _loggedRequests)
            {
                foreach (var info in request.Value)
                {
                    loggedUrls.Add($"HISTORY: {request.Key} || :{info.Url}");
                }
            }
            return loggedUrls;
        }
        public void PutRequest(string controllerName, RequestInfo requestInfo)
        {
            if (_loggedRequests.ContainsKey(controllerName))
            {
                _loggedRequests[controllerName].Add(requestInfo);
            }
            else
            {
                _loggedRequests.Add(controllerName, new List<RequestInfo>() { requestInfo });
            }
        }
    }
}
