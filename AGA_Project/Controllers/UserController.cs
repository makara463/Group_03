using Microsoft.AspNetCore.Mvc;

namespace AGA_Project.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
