using DataModels.SignUp;
using DataModels.Teams;
using Interfaces.DataAccessors;
using Interfaces.Engines;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engines
{
    public class TeamsEngine : ITeamsEngine
    {
        private readonly ITeamsDataAccessor _adminDataAccessor;

        public TeamsEngine(ITeamsDataAccessor adminDataAccessor)
        {
            _adminDataAccessor = adminDataAccessor;
        }

        public async Task<List<StudentSignUpDM>> GetAllStudentsAsync(StudentFilterDM studentFilter)
        {
            return await _adminDataAccessor.GetAllStudentsAsync(studentFilter);
        }

        public async Task<List<CoachSignUpDM>> GetAllCoachesAsync(CoachFilterDM coachFilter)
        {
            return await _adminDataAccessor.GetAllCoachesAsync(coachFilter);
        }
    }
}