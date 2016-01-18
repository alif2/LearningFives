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

        [HttpPost]
        public ActionResult Coach(CoachSignUpVM coachSignUp)
        {
            _signUpManager.RegisterCoach(coachSignUp);
            return View();
        }

        public ActionResult Student(StudentSignUpVM studentSignUp)
        {
            _signUpManager.RegisterStudent(studentSignUp);
            return View();
        }
    }
}