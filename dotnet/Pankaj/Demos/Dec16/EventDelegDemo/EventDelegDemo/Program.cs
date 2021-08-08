using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDelegDemo
{

    delegate void Transaction(int acId, int amt);
    class Bank
    {
        public event Transaction Debit;
        public event Transaction Credit;
    }

    class AxisBank : Bank
    {

    }
    class Program
    {
        static void Main(string[] args)
        {

            AxisBank sbRoad = new AxisBank();

            sbRoad.Credit += SbRoad_Credit;
        }

        private static void SbRoad_Credit(int acId, int amt)
        {
            throw new NotImplementedException();
        }
    }
}
