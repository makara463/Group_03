using Microsoft.AspNetCore.Mvc;
using Testing_data_annotation.Models;

namespace Testing_data_annotation.Controllers
{
    public class EmployeeContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}
