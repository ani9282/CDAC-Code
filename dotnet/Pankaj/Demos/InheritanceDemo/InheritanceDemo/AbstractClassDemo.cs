using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{

  abstract class Account
    {
        public int acId { get; set; }
        public string acHolderName { get; set; }

        public int ROI { get; set; }

        public int Balance { get; set; }

        public abstract int CalcROI();
    }

    class SavingAct : Account
    {
        public override int CalcROI()
        {
            throw new NotImplementedException();
        }
    }
    class CurrentAct : Account
    {
        public override int CalcROI()
        {
            throw new NotImplementedException();
        }
    }
    class AbstractClassDemo
    {
        static void Main(string[] args)
        {
            Account obj=null;
            int type = 1;
            switch (type)
            {
                case 1:
                    {
                        obj = new SavingAct();
                        break;
                    }
                case 2:
                    {
                        obj = new CurrentAct();
                        break;
                    }
                default:
                    {
                        obj = new SavingAct();
                        break;
                    }
            }
        }
    }
}
