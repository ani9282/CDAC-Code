using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Configuration;
using System.ServiceModel.Channels;
using System.ServiceModel.MsmqIntegration;
using System.Messaging;
using WCFService;

namespace WCFHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost wcfHost;
            try
            {
                string httpBaseAddress = ConfigurationManager.AppSettings["HTTPBaseAddress"];
                string tcpBaseAddress = ConfigurationManager.AppSettings["TCPBaseAddress"];
                string msmqAddress = ConfigurationManager.AppSettings["MsmqEmpDetails"];
                if (!MessageQueue.Exists(msmqAddress))
                {
                    MessageQueue.Create(msmqAddress, true);
                }
                MessageQueue queue = new MessageQueue(msmqAddress);
                queue.ReceiveCompleted += new ReceiveCompletedEventHandler(EmployeeDetailsEntered);
                queue.BeginReceive();
                Uri httpUri = new Uri(httpBaseAddress);
                Uri tcpUri = new Uri(tcpBaseAddress);
                Uri []addressCollection = new Uri[]{httpUri, tcpUri};

                wcfHost = new ServiceHost(typeof(WCFService.WCFServiceImplement), addressCollection);
                wcfHost.Open();
                Console.WriteLine("WCF service started successfully at :");
                Console.WriteLine(httpBaseAddress);
                Console.WriteLine(tcpBaseAddress);
                Console.WriteLine(msmqAddress);
                Console.WriteLine("Press <ENTER> to exit...");
                Console.ReadLine();
                wcfHost.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            finally
            {
            }
        }

        static void EmployeeDetailsEntered(object sender, ReceiveCompletedEventArgs e)
        {
            try
            {
                MessageQueue msmq = (MessageQueue)sender;
                System.Messaging.Message msg = msmq.EndReceive(e.AsyncResult);
                msg.Formatter = new XmlMessageFormatter(new Type[] { typeof(EmployeePersonalDetails) });
                EmployeePersonalDetails empDetails = (EmployeePersonalDetails) msg.Body;
                Console.WriteLine("Details received: " + empDetails.EmployeeNumber);
                msmq.BeginReceive();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
