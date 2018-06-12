using System.Net.Http;

namespace JSONPlaceholder.Core
{
    public class HttpProvider
    {
        private readonly HttpClient _client;

        public HttpProvider()
        {
            _client = new HttpClient();
        }

        /// <summary>
        /// Execute api request and parse results
        /// </summary>
        /// <typeparam name="T">JSONPlaceholder.JsonObjects</typeparam>
        /// <param name="request">JSONPlaceholder.Requests</param>
        /// <returns>parsed json object</returns>
        public T ExecuteApiMethod<T>(HttpRequestMessage request)
        {
            return _client.SendAsync(request).Result.Content.ReadAsAsync<T>().Result;            
        }
    }
}