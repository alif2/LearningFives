using DataModels.SignUp;
using Interfaces.DataAccessors;

namespace DataAccessors
{
    public class SignUpDataAccessor : ISignUpDataAccessor
    {
        public bool RegisterStudent(StudentSignUpDM studentSignUp)
        {
            return false;
        }

        public bool RegisterCoach(CoachSignUpDM coachSignUp)
        {
            return false;
        }
    }
}