using DataModels;
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

        public bool RegisterCoach(CoachSignUpDM coachSignUp)
        {
            return _signUpDataAccessor.RegisterCoach(coachSignUp);
        }
    }
}