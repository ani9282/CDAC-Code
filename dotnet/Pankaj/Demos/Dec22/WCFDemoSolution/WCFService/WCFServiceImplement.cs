using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SystemInfo;
using System.Data;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.MsmqIntegration;
using System.Messaging;

namespace WCFService
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class WCFServiceImplement : IWCFService, IWCFMessageQueue
    {
        #region IWCFService Members

        public string GetSystemIPAddress()
        {
            return new SystemInfo.SystemInfo().GetIPAddress();
        }

        public Employee[] GetEmployees()
        {
            Employee []empArr;
            List<Employee> arr = this.GetEmpolyeeArray();
            empArr = new Employee[arr.Count];
            arr.CopyTo(empArr);
            return empArr;
        }

        public Employee CreateNewEmployee()
        {
            Employee emp = new Employee();
            emp.EmployeeID = new Random().Next(int.MinValue, int.MaxValue);
            emp.Experience = 4.5M;
            emp.FirstName = "First" + System.Guid.NewGuid().ToString();
            emp.LastName = "Last" + System.Guid.NewGuid().ToString();
            emp.Qualification = "Graduate";
            return emp;
        }

        public DataSet GetEmployeeList()
        {
            return new SystemInfo.SystemInfo().GetEmployeeList();
        }
        
        public List<Employee> GetEmpolyeeArray()
        {
            DataSet ds = new SystemInfo.SystemInfo().GetEmployeeList();
            List<Employee> empList = new List<Employee>();            
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                Employee emps;
                emps = new Employee();
                emps.UniqueID = System.Guid.NewGuid().ToString();
                emps.EmployeeID = Convert.ToInt32(row["EmployeeNo"]);
                emps.Experience = Convert.ToDecimal(row["Experience"]);
                emps.FirstName = row["FirstName"].ToString();
                emps.LastName = row["LastName"].ToString();
                emps.MiddleName = row["MiddleName"].ToString();
                emps.Qualification = row["Qualification"].ToString();
                empList.Add(emps);
            }
            return empList;
        }

        public ArrayList GetFirstFiveEmployees()
        {
            List<Employee> firstFive = this.GetEmpolyeeArray();
            ArrayList aList = new ArrayList();
            aList.AddRange(firstFive.GetRange(0, 5));
            return aList;
        }
        #endregion

        #region IWCFMessageQueue Members

        [OperationBehavior(TransactionScopeRequired=true, TransactionAutoComplete=true)]
        public void AddEmployeeDetails(MsmqMessage<EmployeePersonalDetails> empDetails)
        {
            EmployeePersonalDetails empData = (EmployeePersonalDetails)empDetails.Body;
            Console.WriteLine("Details added for employee number:" + empData.EmployeeNumber);
        }

        #endregion
    }
}
