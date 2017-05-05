using System.Collections.Generic;

namespace DataModels.Teams
{
    public class AllSignUpsDM
    {
        public List<StudentSignUp> Students { get; set; }
        public List<CoachProfileAM> Coaches { get; set; }
    }
}