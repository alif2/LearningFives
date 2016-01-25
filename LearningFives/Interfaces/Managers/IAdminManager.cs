using System.Collections.Generic;
using System.Threading.Tasks;
using ViewModels.SignUp;

namespace Interfaces.Managers
{
    public interface IAdminManager
    {
        Task<List<StudentSignUpVM>> GetAllStudentsAsync();
    }
}