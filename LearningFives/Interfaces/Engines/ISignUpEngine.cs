using DataModels.SignUp;

namespace Interfaces.Engines
{
    public interface ISignUpEngine
    {
        bool RegisterStudent(StudentSignUpDM studentSignUp);
        bool RegisterCoach(CoachSignUpDM coachSignUp);
    }
}