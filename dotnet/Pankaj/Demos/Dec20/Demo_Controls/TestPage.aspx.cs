using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class TestPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("hello");
    }
    protected void CallMe(object sender, EventArgs e)
    {
        global::System.Windows.Forms.MessageBox.Show("Welcome");
    }
}