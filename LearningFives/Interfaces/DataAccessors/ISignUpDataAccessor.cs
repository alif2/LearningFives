using System.Threading.Tasks;
using DataModels.SignUp;

namespace Interfaces.DataAccessors
{
    public interface ISignUpDataAccessor
    {
        Task<bool> RegisterStudent(StudentSignUpDM studentSignUp);
        Task<bool> RegisterCoach(CoachSignUpDM coachSignUp);
    }
}