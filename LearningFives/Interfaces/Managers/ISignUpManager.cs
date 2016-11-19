using System.Threading.Tasks;
using ViewModels.SignUp;

namespace Interfaces.Managers
{
    public interface ISignUpManager
    {
        Task<bool> RegisterStudentAsync(StudentSignUpVM studentSignUp);
        Task<bool> RegisterCoachAsync(CoachSignUpVM coachSignUp);
    }
}