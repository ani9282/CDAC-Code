using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AddTwoNum(object op, EventArgs e)
        {
            int num1;
            int num2;
            int numRes; 

            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);

            //BL

            numRes = num1 + num2;
            textBox3.Text = numRes.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void SubTwoNum(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int numRes;

            num1 = Int32.Parse(textBox1.Text);
            num2 = Int32.Parse(textBox2.Text);

            numRes = num1 - num2;
            textBox3.Text = numRes.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
