using ActionModels.Teams;
using Interfaces.Managers;
using System.Threading.Tasks;
using System.Web.Mvc;
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

        public async Task<ActionResult> Index(int studentStatus = -1, string server = null, string rankTier = null)
        {
            ViewBag.StudentStatus = studentStatus;
            ViewBag.Server = server;
            ViewBag.RankTier = rankTier;

            return View(new AllSignUpsAM
            {
                Students = await _teamsManager.GetAllStudentsAsync(new StudentFilterVM
                {
                    StudentStatus = studentStatus,
                    Server = server,
                    RankTier = rankTier
                }),
                Coaches = await _teamsManager.GetAllCoachesAsync(new CoachFilterVM
                {
                    CoachStatus = studentStatus,
                    Server = server,
                    RankTier = rankTier
                })
            });
        }

        public async Task AddStudentToCoach(string coachName, string coachServer, string studentName, string studentServer)
        {
            
        }
    }
}