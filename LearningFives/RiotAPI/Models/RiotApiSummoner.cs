using Newtonsoft.Json;

namespace RiotAPI.Models
{
    [JsonObject]
    public class RiotApiSummoner : RiotApiObject
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("accountId")]
        public long AccountId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("profileIconId")]
        public int ProfileIconId { get; set; }

        [JsonProperty("revisionDate")]
        public long RevisionDate { get; set; }

        [JsonProperty("summonerLevel")]
        public long SummonerLevel { get; set; }
    }
}