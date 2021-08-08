using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IStudentService1
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader sdr;
        public List<Student> FetchAllStudent()
        {
            con = new SqlConnection("Server=192.168.10.4;User id=faculty;password=faculty;database=pankajdb");
            con.Open();
            cmd = new SqlCommand("Select * from Students", con);
            sdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(sdr);
            //Converting Datatable To List
            List<Student> tempList = null;
            if(dt.Rows.Count>0)
            {
                tempList = new List<Student>();
                foreach (DataRow item in dt.Rows)
                {
                    Student s1 = new Student();
                    s1.RollNo = Int32.Parse(item[0].ToString());
                    s1.Name= item[1].ToString();
                    s1.Address = item[2].ToString();
                    tempList.Add(s1);
                }
            }
            return tempList;

        }

        public List<Student> ShowStudentById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
