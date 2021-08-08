using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileIODemo
{
    [Serializable]
    class Student
    {
        public int RollNo;
        public string Name;
        [NonSerialized]
        public int Marks;

    }
}
