using System.Threading.Tasks;
using DataModels.SignUp;

namespace Interfaces.Engines
{
    public interface ISignUpEngine
    {
        Task<bool> RegisterStudent(StudentSignUpDM studentSignUp);
        Task<bool> RegisterCoach(CoachSignUpDM coachSignUp);
    }
}