using DataAccessors;
using System.Collections.Generic;

namespace LearningFives.Models.Teams
{
    public class AllSignUpsVM
    {
        public List<StudentSignUp> Students { get; set; }
        public List<CoachSignUp> Coaches { get; set; }
    }
}