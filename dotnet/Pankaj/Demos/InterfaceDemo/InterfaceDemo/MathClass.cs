using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    public class MathClass : IAdd, ISub, IProd, IDiv,ISubProd,IAddProd,IAll
    {
        public int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Sub(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Prod(int num1, int num2)
        {
            return num1 * num2;
        }
        public int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
