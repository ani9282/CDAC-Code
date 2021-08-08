using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PostBackDemo : System.Web.UI.Page
{
    string[] cities = { "Delhi", "Pune", "Bangalore", "Chennai" };
    protected void Page_Load(object sender, EventArgs e)
    {
        Response.Write("IsPOstBack :" + IsPostBack);

        if (!IsPostBack)
        {
            foreach (var item in cities)
            {
                DropDownList2.Items.Add(item);
            }
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string name = TextBox1.Text;
        string city = DropDownList2.SelectedItem.Text;
        string content = string.Format("Welcome {0},You Lives in {1}", name, city);

        Response.Write("<Marquee><h3>"+content+"</h3></Marquee>");
    }
}