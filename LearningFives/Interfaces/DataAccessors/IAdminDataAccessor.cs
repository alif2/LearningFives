using DataModels.SignUp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.DataAccessors
{
    public interface IAdminDataAccessor
    {
        Task<List<StudentSignUpDM>> GetAllStudentsAsync();
    }
}