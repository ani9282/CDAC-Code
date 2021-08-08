 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentEntity;
using StudentDALProj;

namespace StudentBLProj
{
    public class StudentBL
    {
        StudentDAO sDao = null;

        public StudentBL()
        {
            sDao = new StudentDAO();
        }

        public int CalcTotal(Student s)
        {
            return s.Phy + s.Chem + s.Maths;

        }

        public void CalcAvg(Student s)
        {
            s.Perc = (s.Phy + s.Chem + s.Maths) / 3;
        }

        public bool AddStudent(Student s1)
        {
            s1.Tot = CalcTotal(s1);
            CalcAvg(s1);
            return sDao.AddStudent(s1);
        }

        public List<Student> ShowAllStudents()
        {
            return sDao.ShowAllStudents();
        }

        public Student ShowStudentByID(int id)
        {
            return sDao.ShowStudentByID(id);
        }
    }
}
