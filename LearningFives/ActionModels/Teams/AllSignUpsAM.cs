using System.Collections.Generic;
using ActionModels.SignUp;

namespace ActionModels.Teams
{
    public class AllSignUpsAM
    {
        public List<StudentSignUpAM> Students { get; set; }
        public List<CoachSignUpAM> Coaches { get; set; }
    }
}