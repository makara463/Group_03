using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Crud_User.Controllers
{
    public class RolesController : Controller
    {

        ApplicationDbContext _context = new ApplicationDbContext();
        public ActionResult Index()
        {

            var listofData = _context.roles.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(role model)
        {
            _context.roles.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Data Insert Successfull!!";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(string id)
        {
            var data = _context.roles.Where(x => x.id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(role model)
        {
            var data = _context.roles.Where(x => x.id == model.id).FirstOrDefault();
            if (data != null)
            {
                data.role1 = model.role1;
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }

        public ActionResult Detail(string id)
        {
            var data = _context.roles.Where(x => x.id == id).FirstOrDefault();

            return View(data);
        }

        public ActionResult Delete(string id)
        {
            var data = _context.roles.Where(x => x.id == id).FirstOrDefault();
            _context.roles.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record Delete Success";
            return RedirectToAction("index");
        }
    }
}