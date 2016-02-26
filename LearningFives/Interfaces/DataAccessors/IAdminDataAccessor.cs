using DataModels.SignUp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.DataAccessors
{
    public interface IAdminDataAccessor
    {
        Task<List<StudentSignUpDM>> GetAllStudentsAsync(int pageNumber, int pageSize);
        Task<List<CoachSignUpDM>> GetAllCoachesAsync(int pageNumber, int pageSize);
        Task<List<StudentSignUpDM>> FilterStudentsAsync(int studentStatusId = -1, string server = null, string rankTier = null);
        Task<List<CoachSignUpDM>> FilterCoachesAsync(int coachStatusId = -1, string server = null, string rankTier = null);
    }
}