using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Employee:IComparable<Employee>
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int Exp { get; set; }

        public int CompareTo(Employee other)
        {
            Employee temp = other;
            if(this.Exp>temp.Exp)
            {
                return 1;
            }
            if (this.Exp <temp.Exp)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        }
    }

