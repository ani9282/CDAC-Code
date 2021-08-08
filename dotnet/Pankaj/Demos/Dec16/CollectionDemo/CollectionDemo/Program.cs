using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Product : ICollection
    {
        public int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public bool IsSynchronized
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public object SyncRoot
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {

        public void IEnumerableDemo()
        {
            Department salesObj = new Department()
            {
                DeptID = 11,
                Name = "SALES",
                Location = "Pune"
            };

            foreach (var item in salesObj)
            {
                Console.WriteLine(((Employee)item).EmpName);
            }
        }

        public void ICompareDemo()
        {
            Employee[] myEmp = new Employee[3];

            myEmp[0] = new Employee() { EmpId = 101, EmpName = "Alok", Exp = 5 };
            myEmp[1] = new Employee() { EmpId = 102, EmpName = "Ali", Exp = 8 };
            myEmp[2] = new Employee() { EmpId = 103, EmpName = "Amol", Exp = 2 };
            Array.Sort(myEmp);
            foreach (var item in myEmp)
            {
                string res = String.Format("Employee ID:{0}\tEmployee Name :{1}", item.EmpId, item.EmpName);
                Console.WriteLine(res);
              
            }
        }
        public void ArrayDemo()
        {
            int[] arrNum = { 140, 10, 2, 25, 12, 6, 8, 3 };

          

            Console.WriteLine("Without Sort");
            foreach (var item in arrNum)
            {
                Console.WriteLine(item);
            }

            //Applying Sort on Array
            Array.Sort(arrNum);

           
            Console.WriteLine("With Sort");
            foreach (var item in arrNum)
            {
                Console.WriteLine(item);
            }
          //Displaying Data in Descending Order
            Array.Reverse(arrNum);
            foreach (var item in arrNum)
            {
                Console.WriteLine(item);
            }

        }
        public void ArrayListDemo()
        {
            ArrayList arrList = new ArrayList();
            arrList.Add("Alok");
            arrList.Add("Alok1");
            arrList.Add("Alok2");
            arrList.Add("Alok3");
            arrList.Add("Alok4");
            arrList.Add("Alok3");
            arrList.Add("Alok3");
            arrList.Add("Alok3");
            arrList.Add("Alok3");
            Console.WriteLine("Count :"+arrList.Count);
            Console.WriteLine("Capacity :" + arrList.Capacity);
        }


        static void Main(string[] args)
        {
            Program p1 = new Program();
             p1.ArrayDemo();
            p1.ICompareDemo();
           // p1.ArrayListDemo();

            Stack<Employee> myList = new Stack<Employee>();
            Stack dummy = new Stack();
           

           // p1.IEnumerableDemo();
            
        }
    }
}
