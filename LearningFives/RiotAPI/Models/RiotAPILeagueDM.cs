using Newtonsoft.Json;
using RiotAPI.Enums;
using System.Collections.Generic;

namespace RiotAPI.Models
{
    public class RiotApiLeagueDM : RiotApiObject
    {
        [JsonProperty("entries")]
        public IEnumerable<RiotApiLeagueEntryDM> Entries { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("participantId")]
        public string ParticipantId { get; set; }

        [JsonProperty("queue")]
        public string Queue { get; set; }

        [JsonProperty("tier")]
        public RiotApiEnums.LeagueTier Tier { get; set; }
    }
}