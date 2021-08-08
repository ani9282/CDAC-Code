using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS.BL;
using SMS.Entity;
using SMS.Exceptions;

namespace SMS.UI
{
     class Program
    {
       static StudentBL sbl=null;
        public static void Main()
        {
            sbl = new StudentBL();
            int choice;
            Console.WriteLine("Welcome To BITM College");
            Console.WriteLine("==========================================");
            Console.WriteLine("\tStudent Management System");
            Console.WriteLine("==========================================");
           do
           {
             PrintMenu();        
            Console.Write("\nPlease Enter your Choice :");
            choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            try
                            {
                                AddStudent();
                            }
                            catch (StudentExceptions e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        break;
                    case 2:
                        {
                            try
                            {
                                Console.WriteLine("\n---------  Searching By Student ID  ----------\n");
                                Console.Write("\nPlease Enter your Roll No You want to Search :");
                                int r = Int32.Parse(Console.ReadLine());
                                Student s2 = sbl.SearchStudentByID(r);
                                if (s2 != null)
                                {
                                    Console.WriteLine("Details of Requested Student are as below");
                                    Console.WriteLine("\nRollNo:{0}\nName:{1}\nAddress:{2}\nMarks:{3}\n\n", s2.RollNo, s2.Name, s2.Address, s2.Marks);
                                }
                                else
                                {
                                    Console.WriteLine("\nNo Guest Details Available\n\n");
                                }
                            }
                            catch (StudentExceptions e)
                            {
                                System.Console.WriteLine(e.Message);
                            }
                        }
                        break;
                    case 3:
                        {
                            Console.WriteLine("\n----------- Search By Name of Student  -------\n");
                            Console.Write("\nEnter the Name of Student:");
                            string name = Console.ReadLine();
                             List<Student> s3 = sbl.SearchStudentByName(name);
                             if (s3 != null)
                             {
                                 Console.WriteLine("Details of Requested Student are as below");
                                 foreach (Student s in s3)
                                 {
                                     Console.WriteLine("\nRollNo:{0}\nName:{1}\nAddress:{2}\nMarks:{3}\n\n", s.RollNo, s.Name, s.Address, s.Marks);
                                 }
                             }
                             else
                             {
                                 Console.WriteLine("\nNo Guest Details Available\n\n");
                             }

                        }
                        break;
                    case 4:
                        {
                            Console.WriteLine(" \n--------  Modifying the Details of Student ----------\n");
                            Console.Write("Enter the Roll Number:");
                            int r = Int32.Parse(Console.ReadLine());
                            Console.Write("New Name to be Given:");
                            string name = Console.ReadLine();
                            Console.Write("New Address:");
                            string addrs = Console.ReadLine();
                            Console.Write("New Marks to be updated:");
                            int mrks = Int32.Parse(Console.ReadLine());
                            bool modif = sbl.UpdateStudent(r, name, addrs, mrks);
                            if(modif)
                            {
                                Console.WriteLine("\nSuccessfully Modified Student Details for {0} Roll Number",r);
                            }
                            else
                            {
                                Console.WriteLine("\nError While Modifiying\n");
                            }
                        }
                        break;
                    case 5:
                        {
                            Console.WriteLine("\n -------- Removing Student Details --------\n");
                            Console.Write("Enter the Roll Number:");
                            int r = Int32.Parse(Console.ReadLine());
                            bool rem = sbl.RemoveStudent(r);
                            if(rem)
                            {
                                Console.WriteLine("\nRemoved the Student with {0} Roll Number Successfully.\n",r);
                            }
                            else
                            {
                                Console.WriteLine("\nError While Removing the Student Details\n");
                            }
                        }
                        break;
                    case 6:
                        {
                            try
                            {
                                sbl.DoSerialize();
                            }
                            catch(StudentExceptions e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }
                    case 7:
                        {
                            try
                            {
                             List<Student> tempList= sbl.DoDeSerialize();
                             if (tempList!=null)
                             {
                                 foreach (var item in tempList)
                                 {
                                     Console.WriteLine(item.Name);
                                 }
                             }
                            }
                            catch (StudentExceptions e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            break;
                        }

                
                            
                    default: Console.WriteLine("\nInvalid Choice");
                        break;
                }
            } while (choice != -1);


            Console.ReadLine();
        }
         private static void PrintMenu()
        {
            Console.WriteLine("\n----------- Menu ------------");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Search Student by ID");
            Console.WriteLine("3. Search Student by Name");
            Console.WriteLine("4. Modify Student");
            Console.WriteLine("5. Drop Student");
            Console.WriteLine("6. Serialize Student");
            Console.WriteLine("7. DeSerialize Student");
            Console.WriteLine("8. Exit");
            Console.WriteLine("-----------------------------\n");
        }
        private static void AddStudent()
        {
            Student s = new Student();
            Console.WriteLine("\nStudent Creation\n");
            Console.Write("Please Enter your Roll No :");
            s.RollNo = Int32.Parse(Console.ReadLine());

            Console.Write("Please Enter your Name :");
            s.Name = Console.ReadLine();

            Console.Write("Please Enter your Address :");
            s.Address = Console.ReadLine();

            Console.Write("Please Enter your Marks :");
            s.Marks = Int32.Parse(Console.ReadLine());

            bool studAdded = sbl.AddStudent(s);
            if (studAdded)
            {
                Console.WriteLine("\nRecord Added ...\n");
            }
            else
            {
                Console.WriteLine("\nUnable to add record ...\n");
            }
        }
        
    }
    }  