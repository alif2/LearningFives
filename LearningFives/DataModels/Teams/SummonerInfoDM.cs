namespace DataModels.Teams
{
    public class SummonerInfoDM
    {
        public int SummonerInfoId { get; set; }
        public string SummonerName { get; set; }
        public string Server { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public RiotApiSummonerDM RiotApiInfo { get; set; }
    }
}