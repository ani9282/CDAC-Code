using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Employee
    {
        int empId;
        string empName;
        string addr;

        //default constructor
        public Employee()
        {
            empId=800;
            empName="XYZ";
            addr="Pune";
        }

        //param constructor
        public Employee(int id ,string nm,string addr)
        {
            empId = id;
            empName =nm;
            this.addr = addr;
        }
        public virtual void ShowDetials()
        {
            Console.WriteLine("Showing Details of Employee");
        }

        public virtual int CalcSalary(int bsal)
        {
            return bsal + 10000 + 1500 - 1200;

        }
    }


    class Manager:Employee
    {
        int deptId;
        int incentive;
        int exp;
        string projName;

        public Manager():base()
        {

        }

        public Manager(int id,
                    string name,
                    string homeAddr,
                    int deptId,
                    int incentive,
                    int exp,
                    string projName):base(id,name,homeAddr)
        {
            this.deptId=deptId;
             this.incentive=incentive;
            this.exp=exp;
            this.projName=projName;

        }

        public override void ShowDetials()
        {
            Console.WriteLine("Showing Details of Manager");
        }

        public override int CalcSalary(int bsal)
        {
            return bsal + 20000 + 3500 - 2200;
        }

    }
    class ConstructorInheritance
    {
        static void Main(string[] args)
        {
           // Manager m1 = new Manager(101,"Alok","201,Aundh",11, 25000, 8, "Tera");

            Employee e1 = new Employee();
            Manager m1 = new Manager();

             int empSal= e1.CalcSalary(10000);

             int mgrSal = m1.CalcSalary(10000);

            Console.WriteLine("Emp Sal :"+empSal);

            Console.WriteLine("Manager Sal :" + mgrSal);

        }
    }
}
