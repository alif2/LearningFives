using Interfaces.Managers;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using ViewModels.Admin;
using ViewModels.SignUp;

namespace LearningFives.Controllers
{
    public class AdminController : Controller
    {
        private readonly IAdminManager _adminManager;
        private AllSignUpsVM signUps;

        public AdminController(IAdminManager adminManager)
        {
            _adminManager = adminManager;
            signUps = new AllSignUpsVM();
        }

        // GET: Admin
        [HttpGet]
        public async Task<ActionResult> Index()
        {
            signUps.Students = await _adminManager.GetAllStudentsAsync();
            signUps.Coaches = await _adminManager.GetAllCoachesAsync();

            return View(signUps);
        }

        [HttpPost]
        public ActionResult FilterStudentsByStudentStatus(int studentStatus)
        {
            return View("Index", new AllSignUpsVM
            {
                Students = signUps.Students.Where(student => student.StudentStatus == studentStatus).ToList(),
                Coaches = signUps.Coaches
            });
        }

        [HttpPost]
        public ActionResult FilterCoachesByCoachStatus(int coachStatus)
        {
            return View("Index", new AllSignUpsVM
            {
                Students = signUps.Students,
                Coaches = signUps.Coaches.Where(coach => coach.CoachStatus == coachStatus).ToList()
            });
        }

        [HttpPost]
        public ActionResult FilterStudentsByServer(string server)
        {
            return View("Index", new AllSignUpsVM
            {
                Students = signUps.Students.Where(student => student.SummonerInfo.Server == server).ToList(),
                Coaches = signUps.Coaches
            });
        }

        [HttpPost]
        public ActionResult FilterCoachesByServer(string server)
        {
            return View("Index", new AllSignUpsVM
            {
                Students = signUps.Students,
                Coaches = signUps.Coaches.Where(coach => coach.SummonerInfo.Server == server).ToList()
            });
        }

        [HttpPost]
        public ActionResult FilterStudentsByRankTier(string rankTier)
        {
            return View("Index", new AllSignUpsVM
            {
                Students = signUps.Students.Where(student => student.SummonerInfo.RankTier == rankTier).ToList(),
                Coaches = signUps.Coaches
            });
        }

        [HttpPost]
        public ActionResult FilterCoachesByRankTier(string rankTier)
        {
            return View("Index", new AllSignUpsVM
            {
                Students = signUps.Students,
                Coaches = signUps.Coaches
            });
        }

        // POST: Admin
        [HttpPost]
        public ActionResult Index(StudentSignUpVM studentFilter, CoachSignUpVM coachFilter)
        {
            return View(new AllSignUpsVM
            {
                Students = signUps.Students,
                Coaches = signUps.Coaches
            });
        }
    }
}