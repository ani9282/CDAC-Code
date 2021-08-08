using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empObj1;
            Employee empObj2;

            empObj1 = new Employee();
            empObj1.EmpId = 101;
            empObj1.Name = "alok";
            empObj1.BSal = 15000;
            empObj1.HRA = 12500;
            empObj1.TA = 2500;
            empObj1.PF = 1500;
            empObj1.NetSal = empObj1.BSal + empObj1.HRA + empObj1.TA - empObj1.PF;
            empObj1.GrossSal = empObj1.BSal + empObj1.HRA + empObj1.TA + empObj1.PF;

            empObj2 = new Employee();
            empObj2.EmpId = 102;
            empObj2.Name = "Riya";
            empObj2.BSal = 15000;
            empObj2.HRA = 12500;
            empObj2.TA = 2500;
            empObj2.PF = 1500;
            empObj2.NetSal = empObj2.BSal + empObj2.HRA + empObj2.TA - empObj2.PF;
            empObj2.GrossSal = empObj2.BSal + empObj2.HRA + empObj2.TA + empObj2.PF;

            //Employee tempEmp = new Employee();
            //tempEmp.HRA = empObj1.HRA + empObj2.HRA;

            Employee empObj3 = new Employee();
            empObj3.EmpId = 103;
            empObj3.Name = "Rajat";
            empObj3.BSal = 35000;
            empObj3.HRA = 22500;
           


            int num1 =100;
            int num2=200;
            int res = num1 + num2;


            Employee tempEmp = empObj1 + empObj2+empObj3;
            Console.WriteLine(tempEmp.TA);

            DummyLogic d1 = new DummyLogic();
          
            try
            {
                d1.CallMe();
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error Message: " + e.Message);
            }
          
        }
    }
}
