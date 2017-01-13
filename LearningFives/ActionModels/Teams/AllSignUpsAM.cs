using System.Collections.Generic;

namespace ActionModels.Teams
{
    public class AllSignUpsAM
    {
        public List<StudentProfileAM> Students { get; set; }
        public List<CoachProfileAM> Coaches { get; set; }
    }
}