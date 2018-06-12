using Newtonsoft.Json;

namespace JSONPlaceholder.JsonObjects
{
    public class Post
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int userId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string title { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string body { get; set; }
    }
}
