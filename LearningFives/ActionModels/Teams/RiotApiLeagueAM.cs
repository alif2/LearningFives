using System.Collections.Generic;

namespace ActionModels.Teams
{
    public class RiotApiLeagueAM
    {
        public string LeagueName { get; set; }
        public string QueueType { get; set; }
        public string Tier { get; set; }
        public IEnumerable<RiotApiLeagueEntryAM> LeagueEntries { get; set; }
    }
}