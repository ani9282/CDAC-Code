using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Added References
using StudentEntity;
using StudentExceptions;
using StudentBLProj;

namespace StudentUIProj
{
    public partial class Form1 : Form
    {
        Student sObj = null;
        StudentBL studBL = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcResult_Click(object sender, EventArgs e)
        {
            bool res=false;
            try
            {
                //Accept Student Details
                sObj = new Student();
                sObj.RollNo = Int32.Parse(txtRollNo.Text);
                sObj.Name = txtName.Text;
                sObj.Phy = Int32.Parse(txtPhy.Text);
                sObj.Chem = Int32.Parse(txtChem.Text);
                sObj.Maths = Int32.Parse(txtMaths.Text);

                //Passing Data to BL
                studBL = new StudentBL();
                res = studBL.AddStudent(sObj);
            }
            catch(InvalidMarksException e1)
            {
                MessageBox.Show(e1.Message);
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.Message);
            }

            if(res)
            {
                MessageBox.Show("Record Added");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                TextBox tb=null;
                if(item.GetType()==typeof(TextBox))
                {
                    tb =(TextBox) item;
                    tb.Clear();
                }

            }
        }

        private void txtRollNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Only Numeric data Allowed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2(sObj);
            f2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
