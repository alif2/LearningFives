using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ViewModels.SignUp
{
    public class ToxicSignUpVM
    {
        [DisplayName("Do you consider yourself toxic?")]
        [Required]
        [Range(0, 2)]
        public int ToxicLevel { get; set; }

        public bool HadLowPriorityPunish { get; set; }
        public bool HadChatRestrictions { get; set; }
        public bool HadRankedRestrictions { get; set; }
        public bool HadTemporaryBan { get; set; }
        public bool HadPermanentBan { get; set; }
    }
}