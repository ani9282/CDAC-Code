using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;

namespace StudentDALProj
{
    public class StudentDAO
    {
      static  List<Student> myStudList = null;
        public StudentDAO()
        {
            myStudList = new List<Student>();

        }

        public bool AddStudent(Student stud)
        {
            bool temp;
            if (stud != null)
            {
                myStudList.Add(stud);
                temp = true;
            }
            else
            {
                temp = false;
            }
            return temp;
        }


        public List<Student>  ShowAllStudents()
        {
            return myStudList;
        }

        public Student ShowStudentByID(int id)
        {
            Student temp= myStudList.Find(p => p.RollNo == id);
            return temp;
           // return myStudList;
        }
    }
}
