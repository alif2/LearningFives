﻿using Newtonsoft.Json;
using RiotAPI.Enums;

namespace RiotAPI.Models
{
    public class RiotApiLeagueEntryDM : RiotApiObject
    {
        [JsonProperty("division")]
        public string Division { get; set; }

        [JsonProperty("isFreshBlood")]
        public bool IsFreshBlood { get; set; }

        [JsonProperty("isHotStreak")]
        public bool IsHotStreak { get; set; }

        [JsonProperty("isInactive")]
        public bool IsInactive { get; set; }

        [JsonProperty("isVeteran")]
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

        [JsonProperty("playstyle")]
        public RiotApiEnums.Playstyle Playstyle { get; set; }

        [JsonProperty("wins")]
        public int Wins { get; set; }
    }
}