using DataModels.SignUp;
using Interfaces.DataAccessors;
using Interfaces.Engines;

namespace Engines
{
    public class SignUpEngine : ISignUpEngine
    {
        private readonly ISignUpDataAccessor _signUpDataAccessor;

        public SignUpEngine(ISignUpDataAccessor signUpDataAccessor)
        {
            _signUpDataAccessor = signUpDataAccessor;
        }

        public bool RegisterStudent(StudentSignUpDM studentSignUp)
        {
            return _signUpDataAccessor.RegisterStudent(studentSignUp);
        }

        public bool RegisterCoach(CoachSignUpDM coachSignUp)
        {
            return _signUpDataAccessor.RegisterCoach(coachSignUp);
        }
    }
}