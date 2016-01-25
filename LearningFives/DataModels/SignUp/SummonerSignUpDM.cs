namespace DataModels.SignUp
{
    public class SummonerSignUpDM
    {
        public string SummonerName { get; set; }
        public string Server { get; set; }
        public string RankTier { get; set; }
        public int RankDivision { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public bool HasSlackAccount { get; set; }
    }
}