using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entity
{
   [AttributeUsage(AttributeTargets.Class|AttributeTargets.Property|AttributeTargets.Method)]
    public  class DeveloperAttribute:Attribute
    {
        public int DevId { get; set; }
        public int RevId { get; set; }
        public string ReviewDate { get; set; }
    }
}
