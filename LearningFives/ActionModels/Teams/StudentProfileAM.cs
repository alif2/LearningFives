namespace ActionModels.Teams
{
    public class StudentProfileAM
    {
        public int StudentStatus { get; set; }
        public SummonerInfoAM SummonerInfo { get; set; }
        public RoleSignUpAM RoleInfo { get; set; }
        public AvailabilitySignUpAM AvailabilityInfo { get; set; }
        public string Languages { get; set; }
        public string PairedPlayers { get; set; }
        public string PlayerStrengths { get; set; }
        public string PlayerImprovement { get; set; }
        public string PlayerExpectations { get; set; }
        public CommitmentSignUpAM Commitment { get; set; }
        public ToxicSignUpAM Toxic { get; set; }
        public string MoreInformation { get; set; }
        public bool EmailSignUp { get; set; }
    }
}