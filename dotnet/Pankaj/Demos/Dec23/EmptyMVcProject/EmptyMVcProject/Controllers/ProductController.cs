using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EmptyMVcProject.Models;

namespace EmptyMVcProject.Controllers
{
    public class ProductController : Controller
    {
        ProductRepository myRepo = null;
        public ProductController()
        {
            myRepo = new ProductRepository();

        }
        // GET: Product
        public ActionResult Index()
        {
            return View(ProductRepository.myProdList);
        }



       public ActionResult ShowAllProducts()
        {
            return View(ProductRepository.myProdList);
        }

        // GET: Product/Details/5
        public ActionResult Details(int id)
        {
           Product pObj=   ProductRepository.myProdList.Find(p => p.ProdID == id);
            return View(pObj);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(Product p1)
        {
            try
            {
                // TODO: Add insert logic here
                ProductRepository.myProdList.Add(p1);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View(ProductRepository.myProdList.Where(p=>p.ProdID==id).FirstOrDefault());
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product p1)
        {
            try
            {
                // TODO: Add update logic here
                var res = ProductRepository.myProdList.FirstOrDefault(p => p.ProdID == id);
                if(res!=null)
                {
                    res.ProdName = p1.ProdName;
                    res.UnitPrice = p1.UnitPrice;
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
