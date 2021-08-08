using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfInstance_PerCall
{
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerSession)]
    public class MyService : IMyService
    {
         int m_Counter = 0;

        public int MyMethod()
        {
            m_Counter++;
            return m_Counter;
        }
    }

}
