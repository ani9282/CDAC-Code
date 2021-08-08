using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApplication1.ServiceReference1;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Service1Client obj = new Service1Client();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int eid = Convert.ToInt32(textBox1.Text);
          Employee myEmp=  obj.GetEmployeeDetail(eid);
          label2.Text = myEmp.Eid.ToString();
          label3.Text = myEmp.Ename;
          label4.Text = myEmp.Bsal.ToString();
          label5.Text = myEmp.Dept;
        }
    }
}
