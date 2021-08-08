using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Security;
using System.Security.Principal;
using System.Security.Permissions;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Configuration;

namespace SystemInfo
{
    public class SystemInfo
    {
        public string GetIPAddress()
        {
            IPAddress[] address = Dns.GetHostAddresses(Dns.GetHostName());
            IPAddress sysIp = address[0];
            return sysIp.ToString();            
        }

        public DataSet GetEmployeeList()
        {
            DataSet ds = new DataSet();
            string connString = ConfigurationManager.ConnectionStrings["AccessConnection"].ConnectionString;
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                conn.Open();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Employee", conn);
                cmd.CommandType = CommandType.Text;
                OleDbDataAdapter adpt = new OleDbDataAdapter(cmd);
                adpt.Fill(ds);
                conn.Dispose();
            }
            return ds;
        }
    }
}
