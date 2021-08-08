using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudentService1
    {
        [OperationContract]
        List<Student> FetchAllStudent();

        [OperationContract]
        List<Student> ShowStudentById(int id);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Student
    {
        int rollNo;
        string name;
        string addr;

        [DataMember]
       public int RollNo
        {
            get
            {
                return rollNo;
            }
            set
            {
                rollNo = value;
            }
        }

        [DataMember]
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

        [DataMember]
        public string Address
        {
            get
            {
                return addr;
            }
            set
            {
                addr = value;
            }
        }

    }
}
