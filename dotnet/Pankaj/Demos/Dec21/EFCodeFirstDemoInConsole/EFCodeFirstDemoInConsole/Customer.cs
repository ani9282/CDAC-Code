using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EFCodeFirstDemoInConsole
{
     public class Customer
    {
         public Customer()
         {

         }
        [Key]
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string Addr { get; set; }
    }
}
