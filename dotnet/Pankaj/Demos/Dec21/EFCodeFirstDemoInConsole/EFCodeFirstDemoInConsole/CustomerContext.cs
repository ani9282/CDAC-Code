using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EFCodeFirstDemoInConsole
{
   public class CustomerContext:DbContext
    {
       public CustomerContext():base("name=TescoDBConStr")
       {

       }
       public DbSet<Customer> Customers { get; set; }
    }
}
