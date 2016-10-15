using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.SignUp
{
    public class CoachSignUpVM
    {
        [Required]
        [Range(0, 2)]
        public int CoachStatus { get; set; }

        [Required]
        public SummonerSignUpVM SummonerInfo { get; set; }

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

        [Required]
        public AvailabilitySignUpVM AvailabilityInfo { get; set; }

        [DisplayName("List the languages you speak:")]
        [Required]
        [StringLength(100)]
        public string Languages { get; set; }

        [DisplayName("List the summoner names of students, coaches, or coaches-in-training you wish to be grouped with:")]
        [StringLength(100)]
        public string PairedPlayers { get; set; }

        [DisplayName("Coaching Style / Philosophy:")]
        [Required]
        [StringLength(500)]
        public string CoachingStyle { get; set; }

        [DisplayName("Experience as a Coach:")]
        [Required]
        [StringLength(500)]
        public string CoachingExperience { get; set; }

        [Required]
        public CommitmentSignUpVM Commitment { get; set; }

        [Required]
        public ToxicSignUpVM Toxic { get; set; }

        [DisplayName("Is there anything else you would like us to know?")]
        [Required]
        [StringLength(500)]
        public string MoreInformation { get; set; }

        public bool EmailSignUp { get; set; }
    }
}