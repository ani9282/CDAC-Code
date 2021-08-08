using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FileIODemo
{
    class AllDrives
    {
        static void Main(string[] args)
        {
           // string[] drives={@"c:\","D:\\","E:\\"};

            string[] drives = Environment.GetLogicalDrives();
            Console.WriteLine("Available Drives on local System :");
            foreach (var item in drives)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Please Select Drive Letter for Information :");
            string drvLetter = Console.ReadLine();
            
            //Code to fetch Details about drive

            DriveInfo df = new DriveInfo(drvLetter);
            Console.WriteLine("Drive Name :" + df.Name);
            Console.WriteLine("Format :"+df.DriveFormat);
            Console.WriteLine("Free Space on Drive :" + df.AvailableFreeSpace);
            Console.WriteLine("Type :" + df.DriveType);
            

        }
    }
}
