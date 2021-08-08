using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Entity
{
    [Developer(DevId=101,RevId=204,ReviewDate="04/01/2018")]
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Marks { get; set; }
        
    }
}
