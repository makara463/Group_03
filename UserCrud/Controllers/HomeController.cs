using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserCrud.Controllers
{
    public class HomeController : Controller
    {
        aga_projectEntitiesContext _context = new aga_projectEntitiesContext();
        public ActionResult Index()
        {

            var listofData = _context.users.ToList();
            return View(listofData);
        }
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(user model)
        {
            _context.users.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Data Insert Successfull!!";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.users.Where(x => x.Id == id).FirstOrDefault();
            return View(data);
        }
        [HttpPost]
        public ActionResult Edit(user model)
        {
            var data = _context.users.Where(x => x.Id == model.Id).FirstOrDefault();
            if (data != null)
            {
                data.username = model.username;
                data.password = model.password;
                data.roles = model.roles;
                _context.SaveChanges();
            }
            return RedirectToAction("index");
        }

        public ActionResult Detail(int id)
        {
            var data = _context.users.Where(x => x.Id == id).FirstOrDefault();

            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var data = _context.users.Where(x => x.Id == id).FirstOrDefault();
            _context.users.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Record Delete Success";
            return RedirectToAction("index");
        }


    }
}