using DataModels.SignUp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces.Engines
{
    public interface IAdminEngine
    {
        Task<List<StudentSignUpDM>> GetAllStudentsAsync();
    }
}