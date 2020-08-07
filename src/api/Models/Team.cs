using Newtonsoft.Json;

namespace NHL_API.Models
{
    public class Team
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("name")]
        public string FullName { get; set; }
        [JsonProperty("venue")]
        public Venue Venue { get; set; }
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }
        [JsonProperty("teamName")]
        public string Name { get; set; }
        [JsonProperty("locationName")]
        public string Location { get; set; }
        [JsonProperty("firstYearOfPlay")]
        public string FirstYear { get; set; }
        [JsonProperty("division")]
        public Division Division { get; set; }
        [JsonProperty("conference")]
        public Conference Conference { get; set; }
        [JsonProperty("franchise")]
        public Franchise Franchise { get; set; }
        [JsonProperty("officialSiteUrl")]
        public string OfficialUrl { get; set; }
        [JsonProperty("active")]
        public bool IsActive { get; set; }
    }
}
