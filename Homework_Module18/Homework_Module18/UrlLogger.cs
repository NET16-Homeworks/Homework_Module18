using Homework_Module18.Controllers;
namespace Homework_Module18
{
    public class UrlLogger
    {
        private static Dictionary<string, List<RequestInfo>> _loggedRequests = new Dictionary<string, List<RequestInfo>>();

        public IEnumerable<string> GetLoggedUrls()
        {
            foreach (var loggedRequest in _loggedRequests)
            {
                foreach (var request in loggedRequest.Value)
                {
                    yield return $"controller name: {loggedRequest.Key}, url request: {request.Url}";
                }
            }
        }

        public void PutRequest(string controllerName, RequestInfo requestInfo)
        {
            if (_loggedRequests.ContainsKey(controllerName))
            {
                _loggedRequests[controllerName].Add(requestInfo);
            }
            
            else
            {
                _loggedRequests.Add(controllerName, new List<RequestInfo>());
                _loggedRequests[controllerName].Add(requestInfo);
            }

        }

            
    }
}
