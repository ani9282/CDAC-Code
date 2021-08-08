using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WCFService
{
    [DataContract]
    [KnownType(typeof(string))]
    [KnownType(typeof(decimal))]
    [KnownType(typeof(int))]
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
