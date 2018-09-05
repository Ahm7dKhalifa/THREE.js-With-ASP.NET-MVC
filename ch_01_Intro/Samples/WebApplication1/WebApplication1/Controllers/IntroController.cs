using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class IntroController : Controller
    {
        // GET: Intro
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SecondExample()
        {
            return View();
        }

        public ActionResult DrawLine()
        {
            return View();
        }
    }
}