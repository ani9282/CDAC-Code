using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Data;
using System.Xml;
using System.Xml.Serialization;

namespace WCFService
{
    [ServiceContract(ProtectionLevel=System.Net.Security.ProtectionLevel.None)]    
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

        //[OperationContract]
        //ArrayList GetFirstFiveEmployees();
    }
}
