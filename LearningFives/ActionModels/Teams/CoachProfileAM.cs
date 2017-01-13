namespace ActionModels.Teams
{
    public class CoachProfileAM
    {
        public int CoachStatus { get; set; }

        public SummonerInfoAM SummonerInfo { get; set; }

        public string InterestedRank { get; set; }

        public bool WillingBronze { get; set; }
        public bool WillingSilver { get; set; }
        public bool WillingGold { get; set; }
        public bool WillingPlat { get; set; }
        public bool WillingDiamond { get; set; }

        public AvailabilitySignUpAM AvailabilityInfo { get; set; }
        public string Languages { get; set; }
        public string PairedPlayers { get; set; }
        public string CoachingStyle { get; set; }
        public string CoachingExperience { get; set; }
        public CommitmentSignUpAM Commitment { get; set; }
        public ToxicSignUpAM Toxic { get; set; }

        public string MoreInformation { get; set; }
        public bool EmailSignUp { get; set; }
    }
}