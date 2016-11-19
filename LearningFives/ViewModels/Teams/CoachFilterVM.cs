namespace ViewModels.Teams
{
    public class CoachFilterVM
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public int CoachStatus { get; set; }
        public string Server { get; set; }
        public string RankTier { get; set; }
    }
}