using Newtonsoft.Json;

namespace NHL_API.Models
{
    public class TimeZone
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("offset")]
        public int Offset { get; set; }
        [JsonProperty("tz")]
        public string Name { get; set; }
    }
}
