using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = null;
    SqlCommand cmd;
    SqlDataReader sdr;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        string rollNo;
        rollNo = TextBox1.Text;
        con = new SqlConnection();
        con.ConnectionString = "Server=192.168.10.4;User Id=faculty;Password=faculty;Database=PankajDb";

        con.Open();
        SqlParameter p1 = new SqlParameter("@rno",rollNo);
        cmd = new SqlCommand();
        cmd.CommandText = "Select * from Students where rollNo=@rno";
        cmd.CommandType = CommandType.Text;
        cmd.Connection = con;


        cmd.Parameters.Add(p1);

       //sdr= cmd.ExecuteReader();
        DataTable dt=null;
        
            sdr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(sdr);
            if(dt.Rows.Count>0)
            {
                GridView1.Visible = true;
            }
      
        
        con.Close();
        GridView1.DataSource = dt;
        GridView1.DataBind();
    }
}