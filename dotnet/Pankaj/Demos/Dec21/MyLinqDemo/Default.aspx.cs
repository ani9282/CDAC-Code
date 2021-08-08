using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq;
using System.Xml.Linq;

public partial class _Default : System.Web.UI.Page
{
    string[] cities = { "Delhi", "Chennai", "Chandigarh", "Pune", "Patna", "Mumbai", "Mangalore","Agra","Agartala"};
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       // GridView1.DataSource = cities;
        //LINQ
        var res = from x in cities
                  where x.EndsWith("a")           
                  select x;
        GridView1.DataSource = res;
        Page.DataBind();
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        CDACDataClassesDataContext cd = new CDACDataClassesDataContext();
       



        Employee e1 = new Employee();
        e1.EmpId = 804;
        e1.EmpName = "Dummy";
        e1.Addr = "Pune";

        cd.Employees.InsertOnSubmit(e1);
        cd.SubmitChanges();
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        CDACDataClassesDataContext cd = new CDACDataClassesDataContext();

        //var res = from x in cd.Employees
        //          where x.EmpId == 804
        //          select x;

       var res=cd.Employees.First(emp => emp.EmpId.Equals(804));

        
        Employee obj = (Employee)res;
        obj.EmpName = "Riya";
        cd.SubmitChanges();

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        CDACDataClassesDataContext cd = new CDACDataClassesDataContext();
        var delEmp = from emp in cd.Employees
                     where emp.EmpId == 804
                     select emp;
        cd.Employees.DeleteAllOnSubmit(delEmp);
        cd.SubmitChanges();
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        CDACDataClassesDataContext cd = new CDACDataClassesDataContext();
        var myEmp = from emp in cd.Employees
                    select new { emp.EmpName, emp.Addr };

        GridView1.DataSource = myEmp;
        Page.DataBind();


    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        /*
       XDocument objXDoc =new XDocument(
           new XComment("XLinq Employees XML example."),
               new XElement("Employees",
                   new XElement("Employee",
                    new XElement("ID","E001"),
                    new XElement("Name","Amit"),
                    new XElement("Designation","Soft. Engg."),
                    new XElement("Department",".Net")),
                    new XElement("Employee",
                    new XElement("ID","E002"),
                    new XElement("Name","Manish"),
                    new XElement("Designation","Soft. Engg."),
                    new XElement("Department",".Net"))));
        * */
        //
        XDocument objXDoc = new XDocument(
      new XComment("XLinq Employees XML example."),
          new XElement("Employees",
              new XElement("Employee",
               new XElement("ID", "E001"),
               new XElement("Name", "Amit")),
               new XElement("Employee",
               new XElement("ID", "E002"),
               new XElement("Name", "Manish"))));


        objXDoc.Save("EmpLinqXML.xml");
        XDocument obj = XDocument.Load("EmpLinqXML.xml");
       
        var EmpNames = from c in obj.Elements("Employees") 
                       select (string)c.Element("Employee");
        //gvShowData.DataSource = VarXDoc;


       GridView1.DataSource = EmpNames;
        // gvShowData.DataSource = objXElem;
       GridView1.DataBind();
    }
}