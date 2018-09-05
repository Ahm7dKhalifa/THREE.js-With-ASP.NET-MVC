using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//working with file
using System.IO;
namespace Sava_Load_Scene_OR_Object.Controllers
{
    public class Export_ImportController : Controller
    {
        /************************************************************************
         * **********************************************************************
         *  1. working with  json file
         *  **********************************************************************
         *  ********************************************************************/
        /*#######################################################
         * save scene
         *#######################################################*/
        // Download_Scene_As_JSON_File
        public ActionResult Download_Scene_As_JSON_File()
        {
            return View();
        }
        // Save_Scene_As_JSON_File_IN_Server
        public ActionResult Save_Scene_As_JSON_File_IN_Server()
        {
            ViewBag.Succ = null;
            return View();
        }
        // Save_Scene_As_JSON_File_IN_Server
        [HttpPost]
        public ActionResult Save_Scene_As_JSON_File_IN_Server(FormCollection formObj)
        {
            string JSON_TEXT = formObj["JSON_TEXT"];
            if(System.IO.File.Exists(Server.MapPath("~/Files/JSON/MyScene.json")))
            {
                System.IO.File.Delete(Server.MapPath("~/Files/JSON/MyScene.json"));
            }
            else
            {
                System.IO.File.WriteAllText(Server.MapPath("~/Files/JSON/MyScene.json"), JSON_TEXT);
            }
           
            
            ViewBag.Succ = "succ to create file :)";
            return View();
        }
        /*#######################################################
         * load compelte scene in json  file
         * #####################################################*/
        public ActionResult LoadCompleteScene()
        {
            return View();
        }

        /*#######################################################
        * load object in json file
        * #####################################################*/
        public ActionResult LoadObject()
        {
            return View();
        }

        /************************************************************************
         * **********************************************************************
         *  2. blender
         *  **********************************************************************
         *  ********************************************************************/
        public ActionResult ImportObjectFromBlender()
        {
            return View();
        }

        public ActionResult ImportObjectFromBlender2()
        {
            return View();
        }

        public ActionResult ImportMultiObject_FromBlender()
        {
            return View();
        }

        /************************************************************************
         * **********************************************************************
         *    .obj and .mtl
         *  **********************************************************************
         *  ********************************************************************/
        public ActionResult ImportDotObj()
        {
            return View();
        }
    }
}