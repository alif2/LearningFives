using ActionModels.SignUp;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewModels.Teams;

namespace Interfaces.Managers
{
    public interface ITeamsManager
    {
        Task<List<StudentSignUpAM>> GetAllStudentsAsync(StudentFilterVM studentFilter);
        Task<List<CoachSignUpAM>> GetAllCoachesAsync(CoachFilterVM coachFilter);
    }
}