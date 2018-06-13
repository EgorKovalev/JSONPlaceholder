using System.Net.Http;

namespace JSONPlaceholder.Requests
{
    public class CommentRequests : BaseRequest
    {
        public static HttpRequestMessage Get(string postId)
        {
            return new HttpRequestMessage(HttpMethod.Get, _baseUrl + "comments?postId=" + postId);
        }
    }
}