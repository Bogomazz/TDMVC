using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TowerDefenceMVC.DAL;
using TowerDefenceMVC.Models;

namespace TowerDefenceMVC.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        Repository repo = new Repository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Attack()
        {
            return View();
        }

        public ActionResult Defense()
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
    }
}