using System;
using System.Collections.Generic;
using System.Text;
using System.ServiceModel;
using System.Runtime.Serialization;

namespace WCFService
{
    [DataContract]
    public class EmployeePersonalDetails
    {
        [DataMember(IsRequired = true)]
        public int EmployeeNumber;
        [DataMember(IsRequired=true)]
        public string FirstAddress;
        [DataMember(IsRequired = true)]
        public string SecondAddress;
        [DataMember(IsRequired = false)]
        public string ThirdAddress;
        [DataMember(IsRequired = true)]
        public string Street;
        [DataMember(IsRequired = true)]
        public string City;
        [DataMember(IsRequired = true)]
        public string State;
        [DataMember(IsRequired = true)]
        public string Country;
        [DataMember(IsRequired = true)]
        public string ZipCode;
    }
}
