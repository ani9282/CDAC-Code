using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Department:IEnumerable
    {
        //Value Type
        public int DeptID { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        //Reference Type
       private Employee[] myEmp = null;

        public Department()
        {
            myEmp = new Employee[5];
            //Object init
            myEmp[0] = new Employee() { EmpId = 101, EmpName = "Alok",Exp=5 };
            myEmp[1] = new Employee() { EmpId = 102, EmpName = "Ali", Exp = 8 };
            myEmp[2] = new Employee() { EmpId = 103, EmpName = "Amol", Exp = 5 };
            myEmp[3] = new Employee() { EmpId = 104, EmpName = "Amita", Exp = 15 };
            myEmp[4] = new Employee() { EmpId = 105, EmpName = "Riya", Exp = 12 };
        }

        public IEnumerator GetEnumerator()
        {
            return myEmp.GetEnumerator();
        }
    }
}
