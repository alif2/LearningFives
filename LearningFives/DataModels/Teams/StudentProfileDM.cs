using DataModels.SignUp;

namespace DataModels.Teams
{
    public class StudentProfileDM
    {
        public int StudentStatus { get; set; }
        public SummonerInfoDM SummonerInfo { get; set; }
        public RoleSignUpDM RoleInfo { get; set; }
        public AvailabilitySignUpDM AvailabilityInfo { get; set; }
        public string Languages { get; set; }
        public string PairedPlayers { get; set; }
        public string PlayerStrengths { get; set; }
        public string PlayerImprovement { get; set; }
        public string PlayerExpectations { get; set; }
        public CommitmentSignUpDM Commitment { get; set; }
        public ToxicSignUpDM Toxic { get; set; }
        public string MoreInformation { get; set; }
        public bool EmailSignUp { get; set; }
    }
}