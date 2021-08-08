using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;//for binary Serialization

namespace FileIODemo
{
    class SerilaizationDemo
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("Student.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            int choice=0;
            Console.WriteLine("------Menu-----");
            Console.WriteLine("1. Serialization \n 2. Deserialization");
            Console.WriteLine("Enter Your choice :");
            choice = Int32.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    {
                        Student s1 = new Student();
                        //Accept data for Student
                        Console.WriteLine("Please  Enter Your RollNo :");
                        s1.RollNo = Int32.Parse(Console.ReadLine());

                        Console.WriteLine("Please  Enter Your Name :");
                        s1.Name = Console.ReadLine();

                        Console.WriteLine("Please  Enter Your Marks :");
                        s1.Marks = Int32.Parse(Console.ReadLine());

                       
                        BinaryFormatter bf = new BinaryFormatter();
                        //Serialization
                        bf.Serialize(fs, s1);
                        break;

                    }
                case 2:
                    {
                        //Deserialization
                        BinaryFormatter bf = new BinaryFormatter();
                        Student myStud = (Student)bf.Deserialize(fs);
                        Console.WriteLine("Roll No :"+myStud.RollNo);
                        Console.WriteLine("Name :" + myStud.Name);
                        Console.WriteLine("Marks :" + myStud.Marks);
                        break;
                    }
                default:
                    break;
            }



          
          
            

            

        }
    }
}
