using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace FileIODemo
{
    class FileStreamDemo
    {
        static void Main(string[] args)
        {
            FileStream fs=null;
            StreamWriter sw=null;
            try
            {
                fs= new FileStream("Hello.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                sw = new StreamWriter(fs);
                sw.Write("This is a sample File");
            }
            catch(FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
             catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                sw.Close();
                fs.Close();
            }
        }
    }
}
