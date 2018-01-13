using DataAccessors;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace LearningFives.Controllers
{
    public class SignUpController : Controller
    {
        private readonly SignUpDataAccessor _signUpDataAccessor;

        public SignUpController(SignUpDataAccessor signUpDataAccessor)
        {
            _signUpDataAccessor = signUpDataAccessor;
        }

        public ActionResult Student()
        {
            return View();
        }

        public ActionResult Coach()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Student(StudentSignUp studentSignUp)
        {
            //If database insert succeeded
            if(await _signUpDataAccessor.RegisterStudent(studentSignUp))
            {
                return View("~/Views/Home/Index.cshtml");
            }
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Coach(CoachSignUp coachSignUp)
        {
            //If database insert succeeded
            if (await _signUpDataAccessor.RegisterCoach(coachSignUp))
            {
                return View("~/Views/Home/Index.cshtml");
            }
            return View();
        }
    }
}