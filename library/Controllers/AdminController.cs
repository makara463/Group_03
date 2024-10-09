using Microsoft.AspNetCore.Mvc;

namespace library.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
