using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.SignUp
{
    public class StudentSignUpVM
    {
        [DisplayName("Registration Type:")]
        [Required]
        [Range(0, 1)]
        public int StudentStatus { get; set; }

        [Required]
        public SummonerSignUpVM SummonerInfo { get; set; }

        [Required]
        public RoleSignUpVM RoleInfo { get; set; }

        [Required]
        public AvailabilitySignUpVM AvailabilityInfo { get; set; }

        [DisplayName("List the languages you speak:")]
        [Required]
        [StringLength(100)]
        public string Languages { get; set; }

        [DisplayName("List the summoner names of players or coaches you wish to be grouped with:")]
        [StringLength(100)]
        public string PairedPlayers { get; set; }

        [DisplayName("What are your strengths as a player?")]
        [Required]
        [StringLength(140)]
        public string PlayerStrengths { get; set; }

        [DisplayName("What skill(s) do you want to improve?")]
        [Required]
        [StringLength(500)]
        public string PlayerImprovement { get; set; }

        [DisplayName("What do you expect from this program?")]
        [Required]
        [StringLength(500)]
        public string PlayerExpectations { get; set; }

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