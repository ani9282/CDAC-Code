using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DataEnabledControls : System.Web.UI.Page
{
    string[] cities = { "Delhi", "Pune", "Bangalore", "Chennai" };
    protected void Page_Load(object sender, EventArgs e)
    {
        ListBox1.DataSource = cities;
       DropDownList1.DataSource = cities;
       RadioButtonList1.DataSource = cities;
        CheckBoxList1.DataSource = cities;
        BulletedList1.DataSource = cities;

        Page.DataBind();
    }
}