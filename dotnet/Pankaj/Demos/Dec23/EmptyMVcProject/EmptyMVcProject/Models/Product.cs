using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmptyMVcProject.Models
{
    public class Product
    {
        public int ProdID { get; set; }
        public string ProdName { get; set; }
        public float UnitPrice { get; set; }
    }
}