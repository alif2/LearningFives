using System.Collections.Generic;
using ViewModels.SignUp;

namespace ViewModels.Admin
{
    public class AllSignUpsVM
    {
        public List<StudentSignUpVM> Students { get; set; }
        public List<CoachSignUpVM> Coaches { get; set; } 
    }
}