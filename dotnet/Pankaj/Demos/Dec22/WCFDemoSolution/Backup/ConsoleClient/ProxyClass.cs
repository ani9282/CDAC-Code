using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime;
using System.Runtime.Serialization;

namespace WCFService
{   
    [ServiceContract]
    public interface IWCFService
    {
        [OperationContract]
        string GetSystemIPAddress();

        //[OperationContract]
        //DataSet GetEmployeeList();

        [OperationContract]
        List<Employee> GetEmpolyeeArray();

        //[OperationContract]
        //Employee[] GetEmployees();

        [OperationContract]
        Employee CreateNewEmployee();
    }

    class ProxyClass : ClientBase<IWCFService>, IWCFService
    {
        #region IWCFService Members

        public string GetSystemIPAddress()
        {
            return base.Channel.GetSystemIPAddress();
        }

        public List<Employee> GetEmpolyeeArray()
        {
            return base.Channel.GetEmpolyeeArray();
        }

        public Employee CreateNewEmployee()
        {
            return base.Channel.CreateNewEmployee();
        }

        #endregion
    }


    [DataContract]
    public class Employee
    {
        [DataMember]
        public string UniqueID;
        [DataMember]
        public int EmployeeID;
        [DataMember]
        public string FirstName;
        [DataMember]
        public string MiddleName;
        [DataMember]
        public string LastName;
        [DataMember]
        public decimal Experience;
        [DataMember]
        public string Qualification;
    }
}
