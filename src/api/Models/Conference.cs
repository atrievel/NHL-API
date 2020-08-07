using Newtonsoft.Json;

namespace NHL_API.Models
{
    public class Conference
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
        [JsonProperty("nameShort")]
        public string ShortName { get; set; }
        [JsonProperty("active")]
        public bool IsActive { get; set; }
    }
}
