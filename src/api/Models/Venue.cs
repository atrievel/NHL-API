using Newtonsoft.Json;
using NHL_API.Utilities;

namespace NHL_API.Models
{
    public class Venue
    {
        [JsonProperty("id")]
        public int? PotentialId { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("link")]
        public string Link { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("timeZone")]
        public TimeZone TimeZone { get; set; }

        public int Id => PotentialId ?? DataFormatter.GetIdFromLink(Link);
    }
}
