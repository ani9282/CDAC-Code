using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Entity;
using SMS.Exceptions;
using SMS.DAL;
using System.Text.RegularExpressions;

namespace SMS.BL
{
    public class StudentBL
    {
        StudentDAO sdao = null; // Creating Object of StudentDAO Class
        public StudentBL()
        {
            sdao = new StudentDAO();
        }
        private static bool validateStudent(Student stud)
        {
            StringBuilder sb = new StringBuilder();
            bool validStud = true;
            if(stud.RollNo < 100 || stud.RollNo > 900)
            {
                validStud = false;
                sb.Append(Environment.NewLine + "Enter the Roll No between 100-900");

            }
            var StudReExp = new Regex("^[A-Za-z]+$");
            if ((StudReExp.IsMatch(stud.Name)))
            {
                validStud = true;
            }
            else
            {
                validStud = false;
                sb.Append(Environment.NewLine + "Student Name should contain only Alphabets");
            }
            if(stud.Address.Length > 100)
            {
                validStud = false;
                sb.Append(Environment.NewLine + "Max Length is 100 Chars");
            }
            if(stud.Marks < 0 || stud.Marks > 100)
            {
                validStud = false;
                sb.Append(Environment.NewLine + "Marks should be in between 0-100");
            }
            if (validStud == false)
                throw new StudentExceptions(sb.ToString());
            return validStud;
        }
        
        public  bool AddStudent(Student stud)
        {
            bool studAdded = false;
            try
            {
                if (validateStudent(stud))
                {
                    //StudentDAO sbl = new StudentDAO();
                    studAdded = sdao.AddStudent(stud);
                }
            }
            catch(StudentExceptions)
            {
                throw;
            }
            catch(Exception e)
            {
                throw e;
            }
            return studAdded;
            //Invoking DAO Class Function
            // return sdao.AddStudent(stud);
        }
        public bool  UpdateStudent(int id,string name, string addr,int marks)
        {
            //Invoking DAO Class Function
            return sdao.UpdateStudent(id, name, addr, marks);
        }
        public bool RemoveStudent(int id)
        {
            //Invoking DAO Class Function
            return sdao.RemoveStudent(id);
        }
        public Student SearchStudentByID(int id)
        {
            //Invoking DAO Class Function
            return sdao.SearchStudentByID(id);
        }
        public List<Student> SearchStudentByName(string name)
        {
            //Invoking DAO Class Function
            return sdao.SearchStudentByName(name);
        }
        public List<Student> DoDeSerialize()
        {
            return sdao.DoDeSerialize();
        }
         public bool DoSerialize()
        {
            return sdao.DoSerialize();
        }

    }
}
