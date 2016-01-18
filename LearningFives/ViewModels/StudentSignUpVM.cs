using System.Collections.Generic;
using System.ComponentModel;

namespace ViewModels
{
    public class StudentSignUpVM
    {
        public int StudentStatus { get; set; }
        public SummonerSignUpVM SummonerInfo { get; set; }
        public RoleSignUpVM RoleInfo { get; set; }
        public AvailabilitySignUpVM AvailabilityInfo { get; set; }

        [DisplayName("List the languages you speak:")]
        public List<string> Languages { get; set; }

        [DisplayName("List the summoner names of players or coaches you wish to be grouped with:")]
        public List<string> PairedPlayers { get; set; } 
        public string MoreInformation { get; set; }
        public bool EmailSignUp { get; set; }
    }
}