using DataModels.SignUp;
using DataModels.Teams;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.DataAccessors
{
    public interface ITeamsDataAccessor
    {
        Task<List<StudentSignUpDM>> GetAllStudentsAsync(StudentFilterDM studentFilter);
        Task<List<CoachSignUpDM>> GetAllCoachesAsync(CoachFilterDM coachFilter);
    }
}