using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfFaultServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    class SampleService : ISampleService
    {
        #region ISampleService Members

        public string SampleMethod(string msg)
        {
            Console.WriteLine("Client said: " + msg);
            // Generate intermittent error behavior.
            Random rnd = new Random(DateTime.Now.Millisecond);
            int test = rnd.Next(5);
            if (test % 2 != 0)
                return "The service greets you: " + msg;
            else
                throw new FaultException<GreetingFault>(new GreetingFault("A Greeting error occurred. You said: " + msg));
        }

        #endregion
    }

}
