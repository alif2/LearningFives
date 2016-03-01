using System.Collections.Generic;
using System.Threading.Tasks;
using ViewModels.Admin;
using ViewModels.SignUp;

namespace Interfaces.Managers
{
    public interface IAdminManager
    {
        Task<List<StudentSignUpVM>> GetAllStudentsAsync(GetStudentsVM studentFilter);
        Task<List<CoachSignUpVM>> GetAllCoachesAsync(GetCoachesVM coachFilter);
    }
}