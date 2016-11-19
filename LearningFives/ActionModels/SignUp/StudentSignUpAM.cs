using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionModels.SignUp
{
    public class StudentSignUpAM
    {
        public int StudentStatus { get; set; }
        public SummonerSignUpAM SummonerInfo { get; set; }
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