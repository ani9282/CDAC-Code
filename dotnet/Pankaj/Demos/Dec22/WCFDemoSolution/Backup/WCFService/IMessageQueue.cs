using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.MsmqIntegration;
using System.Messaging;

namespace WCFService
{
    [ServiceContract]
    [ServiceKnownType(typeof(EmployeePersonalDetails))]
    public interface IWCFMessageQueue
    {
        [OperationContract(IsOneWay = true, Action="*")]
        void AddEmployeeDetails(MsmqMessage<EmployeePersonalDetails> empDetails);
    }   
}
