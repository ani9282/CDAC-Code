using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.ServiceModel;
using WCFClient;
using WCFService;

namespace WCFClient
{
    public partial class WCFClient : Form
    {
        public WCFClient()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            using (WCFServiceClient client = new WCFServiceClient("WCFServiceEndPoint"))
            {
                try
                {
                    label1.Text = "Server IP: " + client.GetSystemIPAddress();
                    //dataGridView1.DataSource = client.GetEmployeeList().Tables[0].DefaultView;
                    Employee[] emps = client.GetEmpolyeeArray();
                    dataGridView1.DataSource = emps;
                    MessageBox.Show("I fetched " + emps.Length + " employees..");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            //using (AlternateClient alClient = new AlternateClient())
            //{
            //    try
            //    {
            //        label1.Text = "Server IP: " + alClient.GetSystemIPAddress();
            //        dataGridView1.DataSource = alClient.GetEmployeeList().Tables[0].DefaultView;
            //        Employee[] emps = alClient.GetEmpolyeeArray();
            //        MessageBox.Show("I fetched " + emps.Length + " employees..");
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.ToString());
            //    }
            //}
        }
    }
}