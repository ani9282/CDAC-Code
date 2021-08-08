using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AllSerializationDemo
{
   [Serializable]
   public class Student
    {
        int rollNo;
        string name;
        [NonSerialized]
        int marks;

       
        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
       public int RollNo
       {
           get { return rollNo; }
           set { rollNo = value; }
       }
    }
}
