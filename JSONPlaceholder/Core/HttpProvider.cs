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

        public T ExecuteApiMethod<T>(HttpRequestMessage request)
        {
            return _client.SendAsync(request).Result.Content.ReadAsAsync<T>().Result;            
        }
    }
}
