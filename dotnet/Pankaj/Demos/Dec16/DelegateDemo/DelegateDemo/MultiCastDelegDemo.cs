using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    //Multicast delegate
    delegate void ChangeCase(string arg);
    class CaseChanger
    {
        public void ChangeToUpper(string str)
        {
            Console.WriteLine(str.ToUpper());
        }

        public static void ChangeToLower(string str)
        {
            Console.WriteLine(str.ToLower());
        }
    }
    class MultiCastDelegDemo
    {
        //static void Main(string[] args)
        //{
        //    CaseChanger c1 = new CaseChanger();

        //    ChangeCase allCase;
        //    ChangeCase lwrCase= new ChangeCase(CaseChanger.ChangeToLower);
           
        //    ChangeCase uprCase = new ChangeCase(c1.ChangeToUpper);

        //    allCase = uprCase + lwrCase;
        //    allCase("AbHishek");
        //}
    }
}
