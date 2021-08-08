using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["Cnt"] = Convert.ToInt32(Session["Cnt"]) + 1;
        Response.Write("Application hit count:  " + Application["Cnt"].ToString()+ "<br>");
        
        Response.Write("Session hit count:  " + Session["Cnt"].ToString());
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Session["FName"] = TextBox1.Text;
        Response.Redirect("Default2.aspx");
    }
}
