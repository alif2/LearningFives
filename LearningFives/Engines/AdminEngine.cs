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

        public async Task<List<StudentSignUpDM>> GetAllStudentsAsync(int pageNumber, int pageSize)
        {
            return await _adminDataAccessor.GetAllStudentsAsync(pageNumber, pageSize);
        }

        public async Task<List<CoachSignUpDM>> GetAllCoachesAsync(int pageNumber, int pageSize)
        {
            return await _adminDataAccessor.GetAllCoachesAsync(pageNumber, pageSize);
        }

        public async Task<List<StudentSignUpDM>> FilterStudentAsync(int studentStatusId = -1, string server = null, string rankTier = null)
        {
            return await _adminDataAccessor.FilterStudentsAsync(studentStatusId, server, rankTier);
        }

        public async Task<List<CoachSignUpDM>> FilterCoachesAsync(int coachStatusId = -1, string server = null, string rankTier = null)
        {
            return await _adminDataAccessor.FilterCoachesAsync(coachStatusId, server, rankTier);
        }
    }
}