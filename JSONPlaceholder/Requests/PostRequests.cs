using JSONPlaceholder.JsonObjects;
using System.Net.Http;
using System.Net.Http.Formatting;

namespace JSONPlaceholder.Requests
{
    public class PostRequests : BaseRequest
    {
        public static HttpRequestMessage Get(string postId = "")
        {
            return new HttpRequestMessage(HttpMethod.Get, _baseUrl + "posts/" + postId);
        }

        public static HttpRequestMessage GetComments(string postId)
        {
            return new HttpRequestMessage(HttpMethod.Get, _baseUrl + "posts/" + postId + "/comments");
        }

        public static HttpRequestMessage Create(Post post)
        {
            var request = new HttpRequestMessage(HttpMethod.Post, _baseUrl + "posts/");
            request.Content = new ObjectContent(post.GetType(), post, new JsonMediaTypeFormatter());
            return request;
        }
    }
}