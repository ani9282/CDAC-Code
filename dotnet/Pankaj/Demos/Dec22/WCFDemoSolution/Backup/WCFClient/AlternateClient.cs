using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Runtime.Serialization;

namespace WCFClient
{
    //[ServiceContract]
    //interface IWCFService
    //{
    //    [OperationContract]
    //    string GetSystemIPAddress();

    //    [OperationContract]
    //    DataSet GetEmployeeList();

    //    [OperationContract]
    //    Employee[] GetEmpolyeeArray();
    //}

    //[ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    //class AlternateClient : ClientBase<IWCFService>, IWCFService
    //{
    //    #region IWCFService Members

    //    public string GetSystemIPAddress()
    //    {
    //        return base.Channel.GetSystemIPAddress();
    //    }

    //    public DataSet GetEmployeeList()
    //    {
    //        return base.Channel.GetEmployeeList();
    //    }

    //    public Employee[] GetEmpolyeeArray()
    //    {
    //        object[] emps = base.Channel.GetEmpolyeeArray();
    //        return (Employee[]) emps;
    //    }
    //    #endregion
    //}

    //[DataContract]    
    //public class Employee
    //{
    //    [DataMember]
    //    public int EmployeeID;
    //    [DataMember]
    //    public string FirstName;
    //    [DataMember]
    //    public string MiddleName;
    //    [DataMember]
    //    public string LastName;
    //    [DataMember]
    //    public decimal Experience;
    //    [DataMember]
    //    public string Qualification;
    //}
}
