using Newtonsoft.Json;

namespace RiotAPI.Models
{
    public class RiotApiLeagueEntry : RiotApiObject
    {
        [JsonProperty("rank")]
        public string Rank { get; set; }

        [JsonProperty("freshBlood")]
        public bool IsFreshBlood { get; set; }

        [JsonProperty("hotStreak")]
        public bool IsHotStreak { get; set; }

        [JsonProperty("inactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("veteran")]
        public bool IsVeteran { get; set; }

        [JsonProperty("leaguePoints")]
        public int LeaguePoints { get; set; }

        [JsonProperty("losses")]
        public int Losses { get; set; }

        [JsonProperty("miniSeries")]
        public RiotApiMiniSeriesDM MiniSeries { get; set; }

        [JsonProperty("playerOrTeamId")]
        public string PlayerOrTeamId { get; set; }

        [JsonProperty("playerOrTeamName")]
        public string PlayerOrTeamName { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}