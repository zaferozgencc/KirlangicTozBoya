﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KirlangicTozBoya.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Title = "Kırlangıç || ELEKTROSTATİK TOZ BOYA";
            return View();
        }

        public ActionResult Slider()
        {
            return View();
        }

        public ActionResult Info()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Projects()
        {
            return View();
        } 
        

    }
}