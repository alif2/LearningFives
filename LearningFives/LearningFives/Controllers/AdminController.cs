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
        [HttpGet]
        public async Task<ActionResult> Index(int pageNumber = 1, int pageSize = 25)
        {
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;

            return View(new AllSignUpsVM
            {
                Students = await _adminManager.GetAllStudentsAsync(pageNumber, pageSize),
                Coaches = await _adminManager.GetAllCoachesAsync(pageNumber, pageSize)
            });
        }
    }
}