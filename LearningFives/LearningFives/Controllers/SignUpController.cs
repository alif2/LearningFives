using System.Web.Mvc;
using ViewModels;

namespace LearningFives.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Coach()
        {
            return View();
        }

        // POST: SignUp
        [HttpPost]
        public ActionResult Coach(StudentSignUpVM studentSignUp)
        {
            return View();
        }

        // GET: SignUp
        public ActionResult Student()
        {
            return View();
        }
    }
}