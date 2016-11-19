using Interfaces.Managers;
using System.Threading.Tasks;
using System.Web.Mvc;
using ActionModels.Teams;
using ViewModels.Teams;

namespace LearningFives.Controllers
{
    public class TeamsController : Controller
    {
        private readonly ITeamsManager _teamsManager;

        public TeamsController(ITeamsManager teamsManager)
        {
            _teamsManager = teamsManager;
        }

        public async Task<ActionResult> Index(int pageNumber = 1, int pageSize = 25, int studentStatus = -1, string server = null, string rankTier = null)
        {
            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            ViewBag.StudentStatus = studentStatus;
            ViewBag.Server = server;
            ViewBag.RankTier = rankTier;

            return View(new AllSignUpsAM
            {
                Students = await _teamsManager.GetAllStudentsAsync(new StudentFilterVM
                {
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    StudentStatus = studentStatus,
                    Server = server,
                    RankTier = rankTier
                }),
                Coaches = await _teamsManager.GetAllCoachesAsync(new CoachFilterVM
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