using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

    class BankEmployee
    {
        public int CalcSal(int bsal)
        {
            int hra;
            int ta;
            int pf;
            hra = bsal * 30/100 ;
            ta = bsal * 10 / 100;
            pf = bsal * 12 / 100;
            return bsal+hra+ta-pf;
        }
    }

   sealed class BankManager:BankEmployee
    {
        public new int CalcSal(int bsal)
        {
            int hra;
            int ta;
            int pf;
            hra = bsal * 50 / 100;
            ta = bsal * 25 / 100;
            pf = bsal * 12 / 100;
            return bsal + hra + ta - pf;
        }
    }

    class BankMgr1:BankManager
    {

    }
    class ShadowingDemo
    {
        static void Main(string[] args)
        {

            BankEmployee alok = new BankEmployee();
            BankManager riya = new BankManager();
            BankEmployee shubham = new BankManager();

            int sal1=  alok.CalcSal(15000);
            int sal2 = riya.CalcSal(20000);
            int sal3 = shubham.CalcSal(20000);

            Console.WriteLine(sal1);
            Console.WriteLine(sal2);
            Console.WriteLine(sal3);

        }
    }
}
