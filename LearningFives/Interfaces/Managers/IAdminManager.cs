using System.Collections.Generic;
using System.Threading.Tasks;
using ViewModels.SignUp;

namespace Interfaces.Managers
{
    public interface IAdminManager
    {
        Task<List<StudentSignUpVM>> GetAllStudentsAsync(int pageNumber, int pageSize);
        Task<List<CoachSignUpVM>> GetAllCoachesAsync(int pageNumber, int pageSize);
    }
}