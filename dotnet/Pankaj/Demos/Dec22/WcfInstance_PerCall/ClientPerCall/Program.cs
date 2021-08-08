using System;
using System.Collections.Generic;
using System.Linq;


namespace ClientPerCall
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
      
        static void Main()
        {
            Console.WriteLine("Service Instance mode: Per-Call");
            Console.WriteLine("Client  making call to service...");
            //Creating the proxy on client side
          ServiceReference1.MyServiceClient proxy =    new ServiceReference1.MyServiceClient();
          ServiceReference1.MyServiceClient proxy1 = new ServiceReference1.MyServiceClient();
          ServiceReference1.MyServiceClient proxy2 = new ServiceReference1.MyServiceClient();
            Console.WriteLine("Proxy Counter: " + proxy.MyMethod());
            Console.WriteLine("Proxy Counter: " + proxy.MyMethod());
            Console.WriteLine("Proxy1 Counter: " + proxy1.MyMethod());
            Console.WriteLine("Proxy1 Counter: " + proxy1.MyMethod());
            Console.WriteLine("Proxy2 Counter: " + proxy2.MyMethod());
            Console.WriteLine("Proxy2 Counter: " + proxy2.MyMethod());
            Console.WriteLine("Proxy2 Counter: " + proxy2.MyMethod());
            Console.WriteLine("Proxy2 Counter: " + proxy2.MyMethod());
            Console.ReadLine();

        }
    }
}
