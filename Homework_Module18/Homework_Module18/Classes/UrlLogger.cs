using Microsoft.AspNetCore.Mvc;

namespace Homework_Module18.Classes
{
    public class UrlLogger
    {
        private static Dictionary<string, List<RequestInfo>> _loggedRequests = new Dictionary<string, List<RequestInfo>>();

        public List<string> GetLoggedUrls()
        {
            var controllerRequests = new List<string>();
            var requestContent = string.Empty;
            foreach (var request in _loggedRequests)
            {
                foreach (var value in request.Value)
                {
                    requestContent = $"{request.Key} {value.Url}";
                    controllerRequests.Add(requestContent);
                }
            }
            return controllerRequests;
        }

        public void PutRequest(string controllerName, RequestInfo requestInfo)
        {
            if(_loggedRequests.ContainsKey(controllerName))
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
