using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Student1.Models;
using System.Data.SqlClient;
namespace Student1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PageAdmin()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult PageUser()
        {
            ViewBag.Message = "Your application description page.";

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

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            if (username == "admin" && password == "admin01")
            {
                return RedirectToAction("PageAdmin", "Home");
            }

            return View();

         }
       }
    }