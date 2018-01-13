using DataAccessors;
using DataAccessors.Models;
using LearningFives.Models.Teams;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LearningFives.Controllers
{
    public class TeamsController : Controller
    {
        private readonly TeamsDataAccessor _teamsDataAccessor;

        public TeamsController()
        {
            _teamsDataAccessor = new TeamsDataAccessor();
        }

        public TeamsController(TeamsDataAccessor teamsDataAccessor)
        {
            _teamsDataAccessor = teamsDataAccessor;
        }

        public async Task<ActionResult> Index(int studentStatus = -1, string server = null, string rankTier = null)
        {
            ViewBag.StudentStatus = studentStatus;
            ViewBag.Server = server;
            ViewBag.RankTier = rankTier;

            return View(new AllSignUpsVM
            {
                Students = await _teamsDataAccessor.GetAllStudentsAsync(new StudentFilterDM
                {
                    StudentStatus = studentStatus,
                    Server = server,
                    RankTier = rankTier
                }),
                Coaches = await _teamsDataAccessor.GetAllCoachesAsync(new CoachFilterDM
                {
                    CoachStatus = studentStatus,
                    Server = server,
                    RankTier = rankTier
                })
            });
        }

        [HttpPost]
        public async Task<string> AddStudentToCoachAsync(int coachSignUpId, int studentSignUpId)
        {
            var added = await _teamsDataAccessor.AddStudentToCoachAsync(coachSignUpId, studentSignUpId);
            return added != null ? "true" : "false";
        }

        [HttpPost]
        public async Task<string> RemoveStudentFromCoachAsync(int coachSignUpId, int studentSignUpId)
        {
            var removed = await _teamsDataAccessor.RemoveStudentFromCoachAsync(coachSignUpId, studentSignUpId);
            return removed != null ? "true" : "false";
        }
    }
}