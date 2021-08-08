using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClientAplica.ServiceReference1;
using System.ServiceModel;

namespace ClientAplica
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorServiceClient obj = new CalculatorServiceClient();

            try
            {
                
                Console.WriteLine("Hello");
                double d = obj.Divide(10d, 0d);
            }
            catch (FaultException<MathFault> e)
            {
              
                Console.WriteLine(e.Detail.Message);
                Console.ReadLine();
                obj.Abort();

            }
        }
    }
}
