using Newtonsoft.Json;

namespace JSONPlaceholder.JsonObjects
{
    public class Comment
    {
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int postId { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public int id { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string name { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string email { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string body { get; set; }
    }
}