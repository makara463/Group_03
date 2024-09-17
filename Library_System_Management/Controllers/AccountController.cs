using Library_System_Management.Entities;
using Library_System_Management.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace Library_System_Management.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;

        }
        public IActionResult Index()
        {

            return View(_context.users.ToList());
        }
        public IActionResult Registration()
        {

            return View();
        }

        public IActionResult Signout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Registration(RegisterUser model)
        {
            if (ModelState.IsValid)
            {
                User users = new User();


                users.FirstName = model.FirstName;
                users.LastName = model.LastName;
                users.Email = model.Email;
                users.Password = model.Password;



                try
                {
                    _context.users.Add(users);
                    _context.SaveChanges();
                    ModelState.Clear();
                    ViewBag.Message = $"{users.FirstName} {users.LastName} Register Successfully!!";
                }
                catch (DbUpdateException ex)
                {
                    ModelState.AddModelError("", "Pls Enter Email or Password");
                    return View(model);
                }


                return View();


            }
            return View(model);
        }

        public IActionResult Login()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _context.users.Where(x => (x.UserName == model.UserNameOrEmail || x.Email == model.UserNameOrEmail) && x.Password == model.Password).FirstOrDefault();
                if (user != null)
                {
                    //Success
                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, user.Email),
                        new Claim("Name",user.FirstName),
                        new Claim(ClaimTypes.Role,"User")
                    };
                    var claimIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimIdentity));

                    return RedirectToAction("SecurePage");
                }
                else
                {
                    ModelState.AddModelError("", "Username/Email or password is not correct");
                }
            }
            return View(model);
        }

        [Authorize]
        public IActionResult SecurePage()
        {
            ViewBag.Name = HttpContext.User.Identity.Name;
            return View();
        }


    }
}
