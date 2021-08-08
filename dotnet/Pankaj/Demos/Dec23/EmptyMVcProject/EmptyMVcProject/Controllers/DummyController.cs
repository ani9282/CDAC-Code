using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmptyMVcProject.Controllers
{
    public class DummyController : Controller
    {
        // GET: Dummy
        public ActionResult Index()
        {
            ViewBag.message = "Welcome to MVC Demo";
            return View();
        }
    }
}