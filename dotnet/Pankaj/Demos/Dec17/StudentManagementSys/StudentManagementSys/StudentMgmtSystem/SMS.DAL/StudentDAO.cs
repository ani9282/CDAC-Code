using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS.Entity;
using SMS.Exceptions;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SMS.DAL
{
    public  class StudentDAO
    {
        static List<Student> myStudList = null;
         static int cnt = 0;
        public StudentDAO()
        {
            myStudList=new List<Student>();
        }
        public  bool AddStudent(Student stud)
        {
            try
            {
                cnt++;
                myStudList.Add(stud);
            }
            catch(StudentExceptions e)
            {
                throw e;
            }
            catch(Exception e)
            {
                throw e;
            }
            if(myStudList.Count == cnt)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public bool UpdateStudent(int id, string name, string addr, int marks)
        {
            Student stud = myStudList.Find(x => x.RollNo == id);
            stud.Name = name;
            stud.Marks = marks;
            stud.Address = addr;
            if(stud != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveStudent(int id)
        {
            Student stud = myStudList.Find(x => x.RollNo == id);
            bool flag = myStudList.Remove(stud);
            return flag;
        }
        public Student SearchStudentByID(int id)
        {
            Student stud = myStudList.Find(x => x.RollNo == id);
            return stud;
        }
        public List<Student> SearchStudentByName(string name)
        {
            List<Student> studlst = myStudList.FindAll(x => x.Name == name);
            return studlst;
        }
        public bool DoSerialize()
        {
            FileStream fs=null;
            bool flag = false;
            try
            {
                fs= new FileStream("Student.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, myStudList);
                flag = true;
             }
            catch (StudentExceptions e)
            {

                throw e;
            }
            catch (FileNotFoundException e)
            {

                throw e;
            }
            catch (Exception e)
            {
                
                throw e;
            }
            return flag;

        }

        public List<Student> DoDeSerialize()
        {
            FileStream fs = null;
             List<Student> newStudList=null;
            
            try
            {
                fs = new FileStream("Student.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                BinaryFormatter bf = new BinaryFormatter();
               newStudList=(List<Student>) bf.Deserialize(fs);
               
            }
            catch (StudentExceptions e)
            {

                throw e;
            }
            catch (FileNotFoundException e)
            {

                throw e;
            }
            catch (Exception e)
            {

                throw e;
            }
            return newStudList;

        }
    }
}
