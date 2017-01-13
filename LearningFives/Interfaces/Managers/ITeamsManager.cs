using ActionModels.Teams;
using System.Collections.Generic;
using System.Threading.Tasks;
using ViewModels.Teams;

namespace Interfaces.Managers
{
    public interface ITeamsManager
    {
        Task<List<StudentProfileAM>> GetAllStudentsAsync(StudentFilterVM studentFilter);
        Task<List<CoachProfileAM>> GetAllCoachesAsync(CoachFilterVM coachFilter);
    }
}