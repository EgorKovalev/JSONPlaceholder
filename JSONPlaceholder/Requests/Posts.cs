using System.Net.Http;

namespace JSONPlaceholder.Requests
{
    public class Posts
    {
        public static HttpRequestMessage Get(string number = "")
        {
            return new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/posts/" + number);
        }
    }
}
