using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EF_CODEFIRST_RELATION_WINDEMO
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var ctx = new MyDbContext())
            {
               Participant stud = new Participant() { PartId=102,PartName = "Ramya" };
                Result res = new Result() {PhyMrk = 87, ChemMrk = 76, MathsMrk = 82, Total = 300, Perc = 76,Participant=stud };

               ctx.Participants.Add(stud);
               ctx.Results.Add(res);
                ctx.SaveChanges();
                MessageBox.Show("Data Saved");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            MyDbContext ctx = new MyDbContext();
            var res = ctx.Results.Find(1);//Fetching The data
            res.Total = 280;//Updating Particular Field
            ctx.SaveChanges();//Commiting the Changes


            MessageBox.Show("Data Updated");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyDbContext ctx = new MyDbContext();
            var res = ctx.Results.Find(2);
            ctx.Results.Remove(res);
            //var res = ctx.Results.Find(1);//Fetching The data
            //res.Total = 280;//Updating Particular Field
            ctx.SaveChanges();//Commiting the Changes
            MessageBox.Show("Data Deleted");

        }
    }
}
