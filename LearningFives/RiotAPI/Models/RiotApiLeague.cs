using Newtonsoft.Json;
using RiotAPI.Enums;
using System.Collections.Generic;

namespace RiotAPI.Models
{
    public class RiotApiLeague : RiotApiObject
    {
        [JsonProperty("leagueId")]
        public string LeagueId { get; set; }

        [JsonProperty("entries")]
        public IEnumerable<RiotApiLeagueEntry> Entries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("tier")]
        public RiotApiEnums.LeagueTier Tier { get; set; }
    }
}