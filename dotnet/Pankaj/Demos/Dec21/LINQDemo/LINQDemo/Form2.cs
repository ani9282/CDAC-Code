using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQDemo
{
    public partial class Form2 : Form
    {
        DataSet1 db = null;
        public Form2()
        {
            InitializeComponent();
            db = new DataSet1();
          
      
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeeTableAdapter1.AddEmployee(999, "Rahul", "121212009", "CHN");

           
             db.AcceptChanges();

           
        }
    }
}
