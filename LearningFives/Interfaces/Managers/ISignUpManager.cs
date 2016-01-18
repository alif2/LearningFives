using ViewModels.SignUp;

namespace Interfaces.Managers
{
    public interface ISignUpManager
    {
        bool RegisterCoach(CoachSignUpVM coachSignUp);
    }
}