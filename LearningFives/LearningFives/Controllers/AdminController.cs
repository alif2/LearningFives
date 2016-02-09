using Interfaces.Managers;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.Admin;

namespace LearningFives.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminManager _adminManager;

        public AdminController(IAdminManager adminManager)
        {
            _adminManager = adminManager;
        }

        // GET: Admin
        public async Task<ActionResult> Index()
        {
            return View(new AllSignUpsVM
            {
                Students = await _adminManager.GetAllStudentsAsync(),
                Coaches = await _adminManager.GetAllCoachesAsync()
            });
        }
    }
}