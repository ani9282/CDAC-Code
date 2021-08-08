using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyMVcProject.Models
{
    public class ProductRepository
    {
       public static List<Product> myProdList = null;
        public ProductRepository()
        {
            myProdList = new List<Product>();
            //Adding Data to List
            myProdList.Add(new Product() { ProdID=101,ProdName="Seagate HDD",UnitPrice=4500});
            myProdList.Add(new Product() { ProdID = 102, ProdName = "Lg TrueVision", UnitPrice = 7500 });
            myProdList.Add(new Product() { ProdID = 103, ProdName = "Logitech Mouse", UnitPrice = 450 });
            myProdList.Add(new Product() { ProdID = 104, ProdName = "TVS KB CherrySoft", UnitPrice = 2500 });
        }
    }
}