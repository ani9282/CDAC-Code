using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Net.Security;

namespace WcfFaultServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ISampleService
    {
        [OperationContract]
        [FaultContractAttribute( typeof(GreetingFault))]
        string SampleMethod(string msg);
    }

    [DataContractAttribute]
    public class GreetingFault
    {
        private string report;

        public GreetingFault(string message)
        {
            this.report = message;
        }

        [DataMemberAttribute]
        public string Message
        {
            get { return this.report; }
            set { this.report = value; }
        }
    }

}
