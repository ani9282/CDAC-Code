using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{

    delegate string GreetMsg(string user);

    class Tamil
    {
        public string GreetInTamil(string name)
        {
            return "Vanakkam " + name;
        }

    }

    class Hindi
    {
        public string GreetInHindi(string name)
        {
            return "Suprabhat " + name;
        }
    }
    class Marathi
    {
        public string GreetInMarathi(string name)
        {
            return "Namaskar " + name;
        }
    }
    class UniCastDelegDemo
    {
        //static void Main(string[] args)
        //{

        //    Marathi m1 = new Marathi();
        //    GreetMsg welcomeMsg = new GreetMsg(m1.GreetInMarathi);
        //    Console.WriteLine(welcomeMsg("Alok"));
        //}
    }
}
