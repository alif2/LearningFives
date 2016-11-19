using DataModels.SignUp;
using DataModels.Teams;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Engines
{
    public interface ITeamsEngine
    {
        Task<List<StudentSignUpDM>> GetAllStudentsAsync(StudentFilterDM studentFilter);
        Task<List<CoachSignUpDM>> GetAllCoachesAsync(CoachFilterDM coachFilter);
    }
}