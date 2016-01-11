using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LearningFives.Controllers
{
    public class SignUpController : Controller
    {
        // GET: SignUp
        public ActionResult Coach()
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