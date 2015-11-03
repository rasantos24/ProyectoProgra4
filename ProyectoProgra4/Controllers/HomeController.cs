using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProyectoProgra4.Models;

namespace ProyectoProgra4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Buenos Días" : "Buenas Tardes";
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(LoginForm loginform)
        {
            if (ModelState.IsValid)
            {
                if (loginform.username == "crivera" && loginform.password == "password")
                {
                    return View("Index");
                }
                else
                {
                    return View("Login");
                }
            }
            else
            {
                return View("Login");

            }

        }

        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ActionResult RsvpForm(GuestResponce guest)
        {
            return View("Thanks", guest);
        }
    }
}