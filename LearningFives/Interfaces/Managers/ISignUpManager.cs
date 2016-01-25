using System.Threading.Tasks;
using ViewModels.SignUp;

namespace Interfaces.Managers
{
    public interface ISignUpManager
    {
        Task<bool> RegisterStudent(StudentSignUpVM studentSignUp);
        Task<bool> RegisterCoach(CoachSignUpVM coachSignUp);
    }
}