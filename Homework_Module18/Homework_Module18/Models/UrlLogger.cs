namespace Homework_Module18.Models
{
    public sealed class UrlLogger
    {
        private static Dictionary<string, List<RequestInfo>> _loggedRequests
            = new Dictionary<string, List<RequestInfo>>();

        public IEnumerable<string> GetLoggedUrls()
        {
            foreach (var logged in _loggedRequests)
            {
                foreach (var request in logged.Value)
                {
                    yield return $"{logged.Key} {request.Url}";
                }
            }
        }

        public void PutRequest(string controller, RequestInfo requestInfo)
        {
            if (_loggedRequests.ContainsKey(controller))
            {
                _loggedRequests[controller].Add(requestInfo);
            }
            else
            {
                _loggedRequests.Add(controller, new List<RequestInfo> { requestInfo });
            }
        }
    }
}
