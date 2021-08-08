using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Messaging;
using System.Configuration;
using System.Transactions;
using WCFService;

namespace MsmqClient
{
    class Program
    {
        static void Main(string[] args)
        {
            string msmq = ConfigurationManager.AppSettings["EmpDetailsQueue"];
            MessageQueue queue = new MessageQueue(@"FormatName:Direct=OS:" + msmq);
            EmployeePersonalDetails empData = new EmployeePersonalDetails();
            empData.City = "Pune";
            empData.Country = "India";
            empData.EmployeeNumber = 12087;
            empData.FirstAddress = "FirstAddress";
            empData.SecondAddress = "SecondAddress";
            empData.State = "Maharashtra";
            empData.Street = "LBS Road";
            empData.ZipCode = "411030";           

            Message msg = new Message();
            msg.Body = empData;
            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.Required))
            {
                queue.Send(msg, MessageQueueTransactionType.Automatic);
                scope.Complete();
            }
            Console.WriteLine("Succesful entry...");
            Console.ReadKey();
        }
    }
}
