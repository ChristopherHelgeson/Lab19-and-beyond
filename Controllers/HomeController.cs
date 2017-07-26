using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoffeeShop.Models;

namespace CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Register()
        {
            ViewBag.Message = "Welcome, new customer! Please register to use our site.";

            return View();
        }

        public ActionResult Login(Register n)
        {
            ViewBag.Message = "Welcome, " + n.FirstName + ".";

            return View(n);
        }

        public ActionResult Summary(Register r)
        {
            ViewBag.Message = "Your email is " + r.Email;
            return View(r);
        }
    }
}