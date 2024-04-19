using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tsupervan.Models;

namespace tsupervan.Controllers
{
    public class HomeController : Controller
    {
        private TsuperVansEntities db = new TsuperVansEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            ViewBag.Roles = new List<Role>
    {
        new Role { RoleID = 1, RoleName = "Admin" },
        new Role { RoleID = 2, RoleName = "User" }
    };

            return View();
        }

        [HttpPost]
        public ActionResult Register(UserRegistration ur)
        {
            if (ModelState.IsValid)
            {
                if (db.UserRegistrations.Any(x => x.Email == ur.Email))
                {
                    ViewBag.Message = "Email already taken!";
                }
                else
                {
                    ur.RoleID = 1;
                    db.UserRegistrations.Add(ur);
                    db.SaveChanges();
                    Response.Write("<script>alert('Registration Successful')</script>");
                }
            }
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLogin u)
        {
            var query = db.UserRegistrations.SingleOrDefault(m => m.Email  == u.Email && m.Password == u.Password);

            if (query != null)
            {
                Response.Write("<script>alert('Login Successful!')</script>");
            }
            else
            {
                Response.Write("<script>alert('Invalid username or password!')</script>");
            }

            return View();
        }
    }
}


