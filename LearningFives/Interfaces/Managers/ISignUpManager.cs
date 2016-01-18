using ViewModels.SignUp;

namespace Interfaces.Managers
{
    public interface ISignUpManager
    {
        bool RegisterStudent(StudentSignUpVM studentSignUp);
        bool RegisterCoach(CoachSignUpVM coachSignUp);
    }
}