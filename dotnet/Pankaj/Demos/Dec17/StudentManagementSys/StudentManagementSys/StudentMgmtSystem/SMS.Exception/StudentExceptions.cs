using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Exceptions
{
    public class StudentExceptions:ApplicationException
    {
        public StudentExceptions():base()
        {

        }
        public StudentExceptions(string message):base(message)
        {

        }
    }
}
