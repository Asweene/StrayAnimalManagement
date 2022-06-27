using Microsoft.AspNetCore.Mvc;

namespace AnimalManagement.Controllers
{
    public class ServicesController : Controller
    {
        
        public ViewResult Index()
        {
            return View();
        }
        
        public ViewResult Adopt()
        {
            return View();
        }

        public ViewResult Donate()
        {
            return View();
        }
    }
}
