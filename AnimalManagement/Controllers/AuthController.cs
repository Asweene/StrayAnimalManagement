using Microsoft.AspNetCore.Mvc;

namespace AnimalManagement.Controllers
{
    public class AuthController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }

        public ViewResult Signup()
        {
            return View();
        }
    }
}
