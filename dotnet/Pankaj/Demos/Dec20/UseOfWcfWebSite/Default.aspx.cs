using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyRef;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        StudentService1Client obj = new StudentService1Client();
        GridView1.DataSource = obj.FetchAllStudent();
        Page.DataBind();

    }
}