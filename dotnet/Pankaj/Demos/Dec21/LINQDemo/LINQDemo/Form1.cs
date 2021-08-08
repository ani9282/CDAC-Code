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
    public partial class Form1 : Form
    {
        string[] Tools = { "BandSaw", "TapDrill", "Hammer", "ScrewDriver", "Plier", "Spanner" };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  listBox1.DataSource = Tools;
          //LINQ Approach

            var result=from item in Tools
                       where item.Contains("S")
                       select item;

            listBox1.DataSource = result.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LINQToSQLForm frm1 = new LINQToSQLForm();
            frm1.Show();
        }
    }
}
