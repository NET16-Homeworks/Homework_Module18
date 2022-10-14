namespace Homework_Module18.Classes
{
    public class UrlLogger
    {
        private static Dictionary<string, List<RequestInfo>> _loggedRequests = new Dictionary<string, List<RequestInfo>>();
        public List<string> GetLoggedUrls()
        {
            List<string> LoggedUrls = new();

            foreach (var request in _loggedRequests)
            {
                foreach (var item in request.Value)
                {
                    LoggedUrls.Add($"{request.Key}:{item.Url}");
                }
            }
            return LoggedUrls;
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
