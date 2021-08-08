using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDataContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public Employee GetEmployeeDetail(int empId)
        {
            Employee e1 = new Employee();
            switch(empId)
            {
                case 1:
                    {
                        e1.Eid = 101;
                        e1.Ename = "Alok";
                        e1.Bsal = 345000;
                        e1.Dept = "Sales";
                        break;
                    }
                case 2:
                    {
                        e1.Eid = 102;
                        e1.Ename = "Ananya";
                        e1.Bsal = 345000;
                        e1.Dept = "HR";
                        break;
                    }

                default:
                   
                        break;
            }
                    
                    return e1;
            }
        }
    }

