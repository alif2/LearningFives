using System.Collections.Generic;

namespace ActionModels.Teams
{
    public class RiotApiSummonerAM
    {
        public long RiotApiSummonerId { get; set; }
        public long ProfileIconId { get; set; }
        public long RevisionDate { get; set; }
        public long SummonerLevel { get; set; }
        public IEnumerable<RiotApiLeagueAM> Leagues { get; set; }
    }
}