using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Events.Controllers
{
    public class EventsController : Controller
    {
        /*========================================================
         * event with three.x.dom.js
         * ======================================================*/
        public ActionResult FirstExample()
        {
            return View();
        }
       /*========================================================
       * event with domEvents
       * ======================================================*/
        public ActionResult SecondExample()
        {
            return View();
        }
       /*========================================================
       * drag and drop event
       * ======================================================*/
        public ActionResult ThirdExample()
        {
            return View();
        }
    }
}