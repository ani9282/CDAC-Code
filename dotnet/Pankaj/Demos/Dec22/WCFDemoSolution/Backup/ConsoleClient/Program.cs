using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.ServiceModel;
using WCFService;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key = new ConsoleKeyInfo();

            while (key.Key != ConsoleKey.Backspace)
            {
                //using (WCFServiceClient client = new WCFServiceClient("TCPEndPoint"))
                //{
                //    Console.WriteLine(client.GetSystemIPAddress());
                //    WCFService.Employee[] emps = client.GetEmpolyeeArray();
                //    Console.WriteLine("I got {0} employees", emps.Length);
                //    key = Console.ReadKey();
                //}

                using (ProxyClass pc = new ProxyClass())
                {
                    Console.WriteLine(pc.GetSystemIPAddress());
                    List<Employee> emps = pc.GetEmpolyeeArray();
                    Console.WriteLine("I got {0} employees", emps.Count);
                    key = Console.ReadKey();
                }
            }            
        }
    }
}
