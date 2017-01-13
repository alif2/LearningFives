namespace ActionModels.Teams
{
    public class RiotApiLeagueEntryAM
    {
        public string Division { get; set; }
        public bool IsFreshBlood { get; set; }
        public bool IsHotStreak { get; set; }
        public bool IsInactive { get; set; }
        public bool IsVeteran { get; set; }
        public int LeaguePoints { get; set; }
        public int Losses { get; set; }
        public int Wins { get; set; }
    }
}