namespace Homework_Module18.Classes
{
    public class UrlLogger
    {
        public static Dictionary<string, List<RequestInfo>> _loggedRequests = new();

        public List<string> GetLoggedUrls()
        {
            List<string> urlList = new();

            foreach (KeyValuePair<string, List<RequestInfo>> item in _loggedRequests)
            {
                foreach (RequestInfo requestInfo in item.Value)
                {
                    urlList.Add($"{item.Key} => {requestInfo.Url}");
                }
            }

            return urlList;
        }

        public void PutRequest(string controllerName, RequestInfo requestInfo)
        {
            if (_loggedRequests.ContainsKey(controllerName))
            {
                _loggedRequests[controllerName].Add(requestInfo);

                return;
            }

            _loggedRequests.Add(controllerName, new List<RequestInfo>() { requestInfo } );
        }
    }
}
