using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Test2015Pro.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetForm()
        {
            return RedirectToAction("Index");
        }

        public ActionResult Return()
        {
            return View();
        }
    }
}