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
        Repo repo = new Repo();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Attack()
        {
            if (repo.IsClear())
                repo.Add(new Game() { AttackerName = User.Identity.Name });
            else
            {
                repo.AddToGameWithDefender(User.Identity.Name);
            }

            return View();
        }

        public ActionResult Defence()
        {
            if (repo.IsClear())
                repo.Add(new Game() { DeffenderName = User.Identity.Name });
            else
            {
                repo.AddToGameWithAttacker(User.Identity.Name);
            }

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