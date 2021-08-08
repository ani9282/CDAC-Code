using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;//File Handling
namespace FileIODemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Directory Creation
            string dirName="Sample";
            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Folder already exist!!!");
            }
            else
            {
                Directory.CreateDirectory(dirName);

                Console.WriteLine("Folder Created !!!");
            }

        }
    }
}
