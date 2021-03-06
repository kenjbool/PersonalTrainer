﻿using System.Web.Mvc;
using PersonalTrainer.Controllers;

namespace PersonalTrainer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Here to help you up your game";
            var clientId = TempData["ClientId"];
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}