using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Messaging;
using System.Messaging.Design;

namespace WCFService
{
    [MessageContract]
    public class WCFMessageContract
    {
        [MessageHeader]
        public string JoiningDate;
        [MessageBodyMember]
        public Employee EmployeeMember;
    }
}
