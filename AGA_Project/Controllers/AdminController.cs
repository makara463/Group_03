using Microsoft.AspNetCore.Mvc;

namespace AGA_Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
