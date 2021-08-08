using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;

namespace WCFService
{
    [ServiceContract]
    public interface IWCFMessageContract
    {
        [OperationBehavior]
        void ProcessEmployeeDetails(WCFMessageContract empContract);
    }
}
