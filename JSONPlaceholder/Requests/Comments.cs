using System.Net.Http;

namespace JSONPlaceholder.Requests
{
    public class Comments
    {
        public static HttpRequestMessage Get(string id)
        {
            return new HttpRequestMessage(HttpMethod.Get, "https://jsonplaceholder.typicode.com/comments?postId=" + id);
        }
    }
}