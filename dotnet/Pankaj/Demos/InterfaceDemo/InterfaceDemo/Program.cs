using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            IAdd x = new MathClass();
           IAddProd y = new MathClass();
            IAll z = new MathClass();
            
           
        }
    }
}
