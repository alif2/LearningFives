using Interfaces.Engines;
using Interfaces.Managers;
using ViewModels.SignUp;

namespace Managers
{
    public class SignUpManager : ISignUpManager
    {
        private readonly ISignUpEngine _signUpEngine;

        public SignUpManager(ISignUpEngine signUpEngine)
        {
            _signUpEngine = signUpEngine;
        }

        public bool RegisterCoach(CoachSignUpVM coachSignUp)
        {
            
        }
    }
}
