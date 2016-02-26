using DataModels.SignUp;
using System.Collections.Generic;
using System.Threading.Tasks;
using DataModels.Admin;

namespace Interfaces.DataAccessors
{
    public interface IAdminDataAccessor
    {
        Task<List<StudentSignUpDM>> GetAllStudentsAsync(GetStudentsDM studentFilter);
        Task<List<CoachSignUpDM>> GetAllCoachesAsync(GetCoachesDM coachFilter);
    }
}