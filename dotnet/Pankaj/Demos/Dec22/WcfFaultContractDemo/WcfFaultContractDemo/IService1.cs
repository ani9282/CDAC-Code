using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFaultContractDemo
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        double Add(double a, double b);

        [OperationContract]
        double Multiply(double a, double b);

        [OperationContract]
        double Subtract(double a, double b);

        [OperationContract]
        [FaultContract(typeof(MathFault))]
        double Divide(double a, double b);

        //[OperationContract]
        //[FaultContract(typeof(AgeFault))]
        //bool ValidateMe(int age);

    }
    
    [DataContract]
   public class AgeFault
   {
       string msg;

        [DataMember]
       public string Message
       {
           get { return msg; }
           set { msg = value; }
       }
        public AgeFault(string msg1)
        {
            msg = msg1;
        }


   }

    [DataContract]
    public class MathFault
    {
        private string report;     

        public MathFault(string message)
         {
             this.report = message;
        }

        [DataMember]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }

        
    }

}
