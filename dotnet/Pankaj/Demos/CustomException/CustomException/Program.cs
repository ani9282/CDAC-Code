using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class Person
    {
        int age;

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                if (value < 18 || value > 60)
                {
                    throw new AgeException();
                }
                else
                {
                    age = value;
                }
            }
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Person p1 = new Person();
                p1.Age = 65;
                
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
