using DataModels;

namespace Interfaces.Engines
{
    public interface ISignUpEngine
    {
        bool RegisterCoach(CoachSignUpDM coachSignUp);
    }
}