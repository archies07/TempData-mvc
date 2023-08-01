using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["var1"] = "Message from View Data";
            ViewBag.Var2 = "Message from View Bag";
            TempData["var3"] = "Message from Temp Data";
            string[] games = { "GTA", "asphalt", "Temple Run", "NeedForSpeed" };

            TempData["GamesArray"] = games;

            return RedirectToAction("About");
            //return View();
        }

        public ActionResult About()
        {
            if (TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }

            TempData.Keep();
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            if (TempData["Var3"] != null)
            {
                TempData["Var3"].ToString();
            }
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
   