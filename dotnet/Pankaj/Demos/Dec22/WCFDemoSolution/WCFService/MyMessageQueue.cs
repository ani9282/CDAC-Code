using System;
using System.Collections.Generic;
using System.Text;

namespace WCFService
{
    class MyMessageQueue : IWCFMessageQueue
    {
        #region IWCFMessageQueue Members

        public void AddEmployeeDetails(System.ServiceModel.MsmqIntegration.MsmqMessage<EmployeePersonalDetails> empDetails)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    }
}
