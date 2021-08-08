using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
   public class AgeException:ApplicationException
    {
        string msg = "Age cant be less then 18 or Abpve 60";

        public override string Message
        {
            get
            {
                return msg;
            }
        }

        public AgeException():base()
        {

        }

        public AgeException(string msg):base(msg)
        {

        }
    }
}
