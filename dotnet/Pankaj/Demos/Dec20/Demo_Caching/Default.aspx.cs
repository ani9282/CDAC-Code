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

        if(Cache["FirstCache"] != null)
        {
            TextBox1.Text = (string)Cache["FirstCache"];
        }
        else
        {
           Cache["FirstCache"] = "Cached Data";
           // Cache.Add("FirstCache", "cachedData", null, null, null, null, null);
        }
        Label2.Text = DateTime.Now.ToString();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Cache.Remove("FirstCache");
        TextBox1.Text = "";
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Cache["FirstCache"] = TextBox1.Text;
    }
}
