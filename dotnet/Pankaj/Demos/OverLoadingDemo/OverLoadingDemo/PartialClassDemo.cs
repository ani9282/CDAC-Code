using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingDemo
{
   partial class MathLogic
    {
        public int AddMe(int x,int y)
        {
            return x + y;
        }
    }
    class PartialClassDemo
    {
        static void Main(string[] args)
        {
            MathLogic m1 = new MathLogic();
            Console.WriteLine(m1.AddMe(20,30));
        }
    }
}
