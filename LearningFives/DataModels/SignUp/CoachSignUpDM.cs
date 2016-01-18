namespace DataModels.SignUp
{
    public class CoachSignUpDM
    {
        public int CoachStatus { get; set; }

        public SummonerSignUpDM SummonerInfo { get; set; }

        public bool InterestedBronze { get; set; }
        public bool InterestedSilver { get; set; }
        public bool InterestedGold { get; set; }
        public bool InterestedPlat { get; set; }
        public bool InterestedDiamond { get; set; }

        public bool WillingBronze { get; set; }
        public bool WillingSilver { get; set; }
        public bool WillingGold { get; set; }
        public bool WillingPlat { get; set; }
        public bool WillingDiamond { get; set; }

        public AvailabilitySignUpDM AvailabilityInfo { get; set; }
        public string Languages { get; set; }
        public string PairedPlayers { get; set; }
        public string CoachingStyle { get; set; }
        public string CoachingExperience { get; set; }  
        public CommitmentSignUpDM Commitment { get; set; }
        public ToxicSignUpDM Toxic { get; set; }

        public string MoreInformation { get; set; }
        public bool EmailSignUp { get; set; }
    }
}