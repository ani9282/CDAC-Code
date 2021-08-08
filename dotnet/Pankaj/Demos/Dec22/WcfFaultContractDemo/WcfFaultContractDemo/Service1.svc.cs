using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;

namespace WcfFaultContractDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class CalculatorService : ICalculatorService
    {
        public double Add(double a, double b)
        {
           // Thread.Sleep(TimeSpan.FromSeconds(20));
            return a + b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Divide(double a, double b)
        {
            if(b!=0)
            {
                return a/b;
            }
            else
            {
                 throw new FaultException<MathFault>(new MathFault("value of (b) should be non-zero!"));
            }

           
              //  throw new FaultException<InvalidOperationException>(new InvalidOperationException("value of (b) should be non-zero!"));
        }

           
        }
    }

