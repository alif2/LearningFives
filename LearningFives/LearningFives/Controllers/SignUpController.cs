using System.Web.Mvc;
using ViewModels.SignUp;

namespace LearningFives.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Coach()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Coach(CoachSignUpVM coachSignUp)
        {
            return View();
        }

        public ActionResult Student(StudentSignUpVM studentSignUp)
        {
            return View();
        }
    }
}