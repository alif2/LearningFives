using DataModels.Teams;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Engines
{
    public interface ITeamsEngine
    {
        Task<List<StudentProfileDM>> GetAllStudentsAsync(StudentFilterDM studentFilter);
        Task<List<CoachProfileDM>> GetAllCoachesAsync(CoachFilterDM coachFilter);
    }
}