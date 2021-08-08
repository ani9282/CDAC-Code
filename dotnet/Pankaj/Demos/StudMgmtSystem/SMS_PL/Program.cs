using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS_Entity;

namespace SMS_PL
{
    class EngStudent:Student
    {

        public string HomeAddr
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
          
        public void Show()
        {
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            EngStudent e1 = new EngStudent();
            e1.HomeAddr = "Pune";
           
        }
    }
}
