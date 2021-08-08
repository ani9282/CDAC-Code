using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinEventDelegDemo
{
    public partial class Form1 : Form
    {
        MITS m1; 
        public Form1()
        {
            m1 = new MITS();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            m1.Pass += new MITS.mydel(m1_Pass);
            m1.Fail += new MITS.mydel(m1_Fail);
            m1.Marks = Convert.ToInt32(textBox1.Text);
        }



        void m1_Fail()
        {
            MessageBox.Show("Fail");
        }
        
        void m1_Pass()
        {
            MessageBox.Show("Pass");
        }
    }
}
