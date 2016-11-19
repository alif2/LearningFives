using System.Collections.Generic;

namespace DataModels.Teams
{
    public class RiotApiLeagueDM
    {
        public string LeagueName { get; set; }
        public string QueueType { get; set; }
        public string Tier { get; set; }
        public IEnumerable<RiotApiLeagueEntryDM> LeagueEntries { get; set; }
    }
}