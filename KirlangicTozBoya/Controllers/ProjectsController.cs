using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KirlangicTozBoya.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult Index()
        {
            ViewBag.Title = "Kırlangıç || HİZMETLERİMİZ ";
            return View();
        }
    }
}