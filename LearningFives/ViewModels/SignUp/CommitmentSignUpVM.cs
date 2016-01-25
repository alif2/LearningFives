using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.SignUp
{
    public class CommitmentSignUpVM
    {
        [DisplayName("Are you committed to participating with the team, twice a week, for the next five weeks?")]
        [Required]
        [Range(0, 2)]
        public int CommitmentLevel { get; set; }

        [DisplayName("How serious should your team be about League of Legends and Learning Fives?")]
        [Required]
        [Range(0, 2)]
        public int SeriousnessLevel { get; set; }
    }
}