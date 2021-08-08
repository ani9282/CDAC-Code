using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingDemo
{
    class DummyLogic
    {
        public void CallMe()
        {
            int num;
            Console.WriteLine("Please Enter Num :");
            num = Int32.Parse(Console.ReadLine());
            Console.WriteLine(num);
        }
    }
}
