using DataModels.Teams;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.DataAccessors
{
    public interface ITeamsDataAccessor
    {
        Task<List<StudentProfileDM>> GetAllStudentsAsync(StudentFilterDM studentFilter);
        Task<List<CoachProfileDM>> GetAllCoachesAsync(CoachFilterDM coachFilter);
    }
}