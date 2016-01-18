using System.Threading.Tasks;
using Interfaces.Managers;
using System.Web.Mvc;
using ViewModels.SignUp;

namespace LearningFives.Controllers
{
    public class SignUpController : Controller
    {
        private readonly ISignUpManager _signUpManager;

        public SignUpController(ISignUpManager signUpManager)
        {
            _signUpManager = signUpManager;
        }

        // GET: SignUp
        public ActionResult Coach()
        {
            return View();
        }

        public ActionResult Student()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Coach(CoachSignUpVM coachSignUp)
        {
            await _signUpManager.RegisterCoach(coachSignUp);
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Student(StudentSignUpVM studentSignUp)
        {
            await _signUpManager.RegisterStudent(studentSignUp);
            return View();
        }
    }
}