using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AGA_Project.Controllers
{
    public class UsersController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }
    }
}
