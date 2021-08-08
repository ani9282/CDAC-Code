using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDataContract
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        Employee GetEmployeeDetail(int empId);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Employee
    {
        int eid;
        [DataMember]
        public int Eid
        {
            get { return eid; }
            set { eid = value; }
        }
        string ename;
        [DataMember]
        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }
        int bsal;
        [DataMember]
        public int Bsal
        {
            get { return bsal; }
            set { bsal = value; }
        }
        string dept;

        [DataMember]
        public string Dept
        {
            get { return dept; }
            set { dept = value; }
        }
    }
}
