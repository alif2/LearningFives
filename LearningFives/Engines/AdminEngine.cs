using DataModels.Admin;
using DataModels.SignUp;
using Interfaces.DataAccessors;
using Interfaces.Engines;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Engines
{
    public class AdminEngine : IAdminEngine
    {
        private readonly IAdminDataAccessor _adminDataAccessor;

        public AdminEngine(IAdminDataAccessor adminDataAccessor)
        {
            _adminDataAccessor = adminDataAccessor;
        }

        public async Task<List<StudentSignUpDM>> GetAllStudentsAsync(GetStudentsDM studentFilter)
        {
            return await _adminDataAccessor.GetAllStudentsAsync(studentFilter);
        }

        public async Task<List<CoachSignUpDM>> GetAllCoachesAsync(GetCoachesDM coachFilter)
        {
            return await _adminDataAccessor.GetAllCoachesAsync(coachFilter);
        }
    }
}