using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataAdapter adap1, adap2;
        DataSet ds;
        SqlCommandBuilder bldr = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.BindingContext[0].AddNew();
            //adap1.Update();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection("Server=iet3;User Id=faculty;Password=faculty;Database=PankajDb");
                adap1 = new SqlDataAdapter("Select * from Students", con);
                ds = new DataSet();
                adap1.Fill(ds, "Stud");

                //passing Addapter to builder
                bldr = new SqlCommandBuilder(adap1);

                dataGridView1.DataSource = ds.Tables[0];

                //Binding Data to TextBoxes

                //    foreach (DataRow row in ds.Tables["Stud"].Rows)
                //    {
                //        textBox1.Text = row[0].ToString();
                //        textBox2.Text = row[1].ToString();
                //        textBox3.Text = row[2].ToString();
                //    }

                textBox1.DataBindings.Add("Text", ds.Tables[0], "RollNo");
                textBox2.DataBindings.Add("Text", ds.Tables[0], "Name");
                textBox3.DataBindings.Add("Text", ds.Tables[0], "Addr");
                
            }
            catch(SqlException se)
            {
                MessageBox.Show(se.Message);
            }
            finally
                {
                if(con.State==ConnectionState.Open)
                {
                    con.Close();
                }
            }

        }
    }
}
