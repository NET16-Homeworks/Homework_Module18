using System.Collections.Generic;
using System.Text;

namespace Homework_Module18
{
    public class UrlLogger
    {
        public static Dictionary<string, List<RequestInfo>> _loggedRequests = new Dictionary<string, List<RequestInfo>>();
        public string[] GetLoggedUrls()
        {
            var @enum = GetEnumerable();
            List<string> listOfStrings = new List<string>();
            foreach(var request in @enum)
            {
                listOfStrings.Add(request);
            }
            return listOfStrings.ToArray();
        }
        private IEnumerable<string> GetEnumerable()
        {
            foreach(var request in _loggedRequests)
            {
                foreach (var item in request.Value)
                {
                    yield return $"{request.Key} - {item.Url}";
                }
            }
        }
        public void PutRequest(string controllerName, RequestInfo request)
        {
            if(_loggedRequests.ContainsKey(controllerName))
            {
                _loggedRequests[controllerName].Add(request);
            }
            else
            {
                _loggedRequests.Add(controllerName, new List<RequestInfo>());
                _loggedRequests[controllerName].Add(request);
            }
        }
    }
}
