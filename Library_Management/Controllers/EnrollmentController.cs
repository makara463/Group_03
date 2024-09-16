using Microsoft.AspNetCore.Mvc;

namespace Library_Management.Controllers
{
    public class EnrollmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
