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
    public partial class LINQToSQLForm : Form
    {
        public LINQToSQLForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcon = new DataClasses1DataContext();
            Product pObj = new Product();
            pObj.ProdID = Convert.ToInt32(textBox1.Text);
            pObj.ProdName = textBox2.Text;
            pObj.ProdCategory = textBox3.Text;
            pObj.price= Convert.ToInt32(textBox4.Text);
            pObj.qty = Convert.ToInt32(textBox5.Text);

            dcon.Products.InsertOnSubmit(pObj);
            dcon.SubmitChanges(); 
            MessageBox.Show("Record Saved");


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcon = new DataClasses1DataContext();
            //LINQ Query
            var result = from prod in dcon.Products
                         where prod.ProdID == Int32.Parse(textBox1.Text)
                         select prod;

           // ((Product)result).
            //OR
            Product pObj = dcon.Products.First(p => p.ProdID == Int32.Parse(textBox1.Text));
            pObj.ProdName = textBox2.Text;
            pObj.ProdCategory = textBox3.Text;
            pObj.price = Convert.ToInt32(textBox4.Text);
            pObj.qty = Convert.ToInt32(textBox5.Text);

            dcon.SubmitChanges();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DataClasses1DataContext dcon = new DataClasses1DataContext();
            
            //OR
            Product pObj = dcon.Products.First(p => p.ProdID == Int32.Parse(textBox1.Text));

            if (pObj != null)
            {
                textBox2.Text = pObj.ProdName.ToString();
                textBox3.Text = pObj.ProdCategory.ToString();
                textBox4.Text = pObj.price.ToString();
                textBox5.Text = pObj.qty.ToString();
            }
            else
            {
                MessageBox.Show("No Matching Record");
            }
        }
    }
}
