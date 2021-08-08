using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFornDBFirstApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PankajDbEntities obj = new PankajDbEntities();
            //Creating and Init the Object of Customer Class
            Customer c1 = new Customer();
            c1.CustId = Convert.ToInt32(textBox1.Text);
            c1.CustName =(textBox2.Text);
            c1.Addr = (textBox3.Text);

            obj.Customers.Add(c1);
            obj.SaveChanges();
            MessageBox.Show("Data Added");

        }
    }
}
