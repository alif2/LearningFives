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


        public async Task<ActionResult> Index(int pageNumber = 1, int pageSize = 25, int studentStatus = -1, string server = null, string rankTier = null)
        {
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            ViewBag.StudentStatus = studentStatus;
            ViewBag.Server = server;
            ViewBag.RankTier = rankTier;

            return View(new AllSignUpsVM
            {
                Students = await _adminManager.GetAllStudentsAsync(new GetStudentsVM
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    StudentStatus = studentStatus,
                    Server = server,
                    RankTier = rankTier
                }),
                Coaches = await _adminManager.GetAllCoachesAsync(new GetCoachesVM
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    CoachStatus = studentStatus,
                    Server = server,
                    RankTier = rankTier
                })
            });
        }
    }
}