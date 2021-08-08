using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentExceptions
{
    public class InvalidMarksException:ApplicationException
    {
        public InvalidMarksException():base()
        {

        }
        /// <summary>
        /// Param Constructor for InvalidMarksException
        /// </summary>
        /// <param name="errMsg">Error Message</param>
        public InvalidMarksException(string errMsg):base(errMsg)
        {

        }
    }
}
