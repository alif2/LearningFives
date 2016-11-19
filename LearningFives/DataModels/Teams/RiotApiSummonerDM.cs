using System.Collections.Generic;

namespace DataModels.Teams
{
    public class RiotApiSummonerDM
    {
        public long RiotApiSummonerId { get; set; }
        public long ProfileIconId { get; set; }
        public long RevisionDate { get; set; }
        public long SummonerLevel { get; set; }
        public IEnumerable<RiotApiLeagueDM> Leagues { get; set; }
    }
}