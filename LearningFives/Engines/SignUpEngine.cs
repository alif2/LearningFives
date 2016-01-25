using DataModels.SignUp;
using Interfaces.DataAccessors;
using Interfaces.Engines;
using System.Threading.Tasks;

namespace Engines
{
    public class SignUpEngine : ISignUpEngine
    {
        private readonly ISignUpDataAccessor _signUpDataAccessor;

        public SignUpEngine(ISignUpDataAccessor signUpDataAccessor)
        {
            _signUpDataAccessor = signUpDataAccessor;
        }

        public async Task<bool> RegisterStudent(StudentSignUpDM studentSignUp)
        {
            return await _signUpDataAccessor.RegisterStudent(studentSignUp);
        }

        public async Task<bool> RegisterCoach(CoachSignUpDM coachSignUp)
        {
            return await _signUpDataAccessor.RegisterCoach(coachSignUp);
        }
    }
}