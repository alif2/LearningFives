using Newtonsoft.Json;

namespace RiotAPI.Models
{
    public class RiotApiMiniSeriesDM : RiotApiObject
    {
        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("progress")]
        public string Progress { get; set; }

        [JsonProperty("target")]
        public int Target { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}