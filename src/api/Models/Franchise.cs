using Newtonsoft.Json;
using NHL_API.Utilities;

namespace NHL_API.Models
{
    public class Franchise
    {
        [JsonProperty("franchiseId")]
        public int Id { get; set; }
        [JsonProperty("firstSeasonId")]
        public string FirstSeason { get; set; }
        [JsonProperty("lastSeasonId")]
        public string LastSeason { get; set; }
        [JsonProperty("mostRecentTeamId")]
        public int MostRecentTeamId { get; set; }
        [JsonProperty("teamName")]
        public string Name { get; set; }
        [JsonProperty("locationName")]
        public string Location { get; set; }

        public string FirstSeasonFormated => DataFormatter.SplitSeasonYears(FirstSeason);
        public string LastSeasonFormated => DataFormatter.SplitSeasonYears(LastSeason);
        public string TeamNameFormatted => Location + " " + Name;
    }
}
