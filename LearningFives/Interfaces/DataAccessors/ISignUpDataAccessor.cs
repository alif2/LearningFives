using DataModels.SignUp;

namespace Interfaces.DataAccessors
{
    public interface ISignUpDataAccessor
    {
        bool RegisterStudent(StudentSignUpDM studentSignUp);
        bool RegisterCoach(CoachSignUpDM coachSignUp);
    }
}