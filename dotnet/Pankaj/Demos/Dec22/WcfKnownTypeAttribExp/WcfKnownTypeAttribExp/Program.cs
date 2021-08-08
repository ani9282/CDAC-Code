using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WcfKnownTypeAttribExp
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicleService obj = new VehicleService();
            Vehicle v1 = obj.GetVehicle(2);
            Console.WriteLine(v1.Brand);
        }
    }
}
