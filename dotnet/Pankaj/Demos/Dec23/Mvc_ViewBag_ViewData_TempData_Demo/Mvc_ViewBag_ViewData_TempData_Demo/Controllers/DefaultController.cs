using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ViewBag_ViewData_TempData_Demo.Controllers
{
    public class DefaultController : Controller
    {

        public ActionResult ShowViewData()
        {
            List<string> studList = new List<string>();
            studList.Add("Alok");
            studList.Add("Riya");
            studList.Add("Rajat");

            ViewData["Student"] = studList;
            return View();
        }
        public ActionResult ShowViewBag()
        {
            List<string> studList = new List<string>();
            studList.Add("Alok");
            studList.Add("Riya");
            studList.Add("Rajat");
            ViewBag.Student = studList;
            return View();
        }
        // GET: Default
        public ActionResult ShowTempData()
        {
            return View();
        }
    }
}