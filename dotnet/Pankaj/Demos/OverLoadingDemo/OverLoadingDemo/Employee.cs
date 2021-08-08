using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverLoadingDemo
{
    //POCO Classes or Entity Class
   class Employee
    {
        #region Attributes
      public int id;
        string name;
        int bsal;
        int hra;
        int ta;
        int pf;
        int netSal;
        int grosSal;
        #endregion

        #region Properties

        public int EmpId
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
               name= value;
            }
        }

        public int BSal
        {
            get
            {
                return bsal;
            }
            set
            {
               bsal = value;
            }
        }

        public int HRA
        {
            get
            {
                return hra;
            }
            set
            {
                hra= value;
            }
        }

        public int TA
        {
            get
            {
                return ta;
            }
            set
            {
                ta = value;
            }
        }

        public int PF
        {
            get
            {
                return pf;
            }
            set
            {
                pf = value;
            }
        }

        public int NetSal
        {
            get
            {
                return netSal;
            }
            set
            {
                netSal = value;
            }
        }

        public int GrossSal
        {
            get
            {
                return grosSal;
            }
            set
            {
                grosSal = value;
            }
        }
        #endregion


        public static Employee operator +(Employee e1,Employee e2)
        {
            Employee temp = new Employee();
            temp.hra = e1.hra + e2.hra;
            temp.bsal = e1.bsal + e2.bsal;
            temp.ta = e1.ta + e2.ta;
            temp.pf = e1.pf + e2.pf;
            temp.netSal = e1.netSal + e2.netSal;
            temp.grosSal = e1.grosSal + e2.grosSal;
            return temp;
        }
    }
}


