using Mvc_ADOCRUD_Demo.Models.BL;
using Mvc_ADOCRUD_Demo.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_ADOCRUD_Demo.Controllers
{
    public class PuppiesController : Controller
    {
        PuppiesBL obj = null;
        public PuppiesController()
        {
            obj = new PuppiesBL();
        }
        //
        // GET: /Puppies/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowAllPuppies()
        {
            return View();
        }

        public ActionResult ShowPuppieDetail(int id)
        {
            return View(obj.ShowPuppieByID(id));
        }

        public ActionResult SavePuppies()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SavePuppies(Puppies p)
        {
            obj.SavePuppies(p);
            return View();
        }


    }
}
