using System.ComponentModel;

namespace ViewModels
{
    public class StudentSignUpSurveyVM
    {
        [DisplayName("What are your strengths as a player?")]
        public string PlayerStrengths { get; set; }
        public string PlayerImprovement { get; set; }
        public string PlayerExpectations { get; set; }
    }
}