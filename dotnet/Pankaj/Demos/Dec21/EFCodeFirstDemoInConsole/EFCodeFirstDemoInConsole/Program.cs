using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EFCodeFirstDemoInConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx=new CustomerContext())
            {
                Customer cobj = new Customer() { CustId = 101, CustName = "Alok", Addr = "Pune" };
                ctx.Customers.Add(cobj);
                ctx.SaveChanges();
                Console.WriteLine("Task Done");
            }
            Console.ReadLine();
            
        }
    }
}
