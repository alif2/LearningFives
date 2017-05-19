using System.Collections.Generic;
using DataAccessors;
using DataAccessors.Models;
using System.Threading.Tasks;
using System.Web.Mvc;
using LearningFives.Models.Teams;

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

        public async Task AddStudentToCoachAsync(string coachName, string coachServer, string studentName, string studentServer)
        {
            
        }
    }
}