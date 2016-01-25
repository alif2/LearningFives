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

        public async Task<List<StudentSignUpDM>> GetAllStudentsAsync()
        {
            return await _adminDataAccessor.GetAllStudentsAsync();
        }
    }
}