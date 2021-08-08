using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class DropDownListCntrl : System.Web.UI.Page
{
    string[] Vehicle = { "Car", "Jeep", "Bike" };
    string[] Cars = { "MARUTI 800", "NANO", "i10", "Swift" };
    string[] Jeeps = { "Commander", "TATA SUMO", "TATA SAFARI" };
    string[] Bikes = { "Splendor+", "Karizma", "CBZ", "PulsarDTSi" };
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
           
            DropDownList1.DataSource = Vehicle;
            CheckBoxList1.DataSource = Vehicle;
           RadioButtonList1.DataSource = Vehicle;
            //DropDownList1.DataBind();
            //CheckBoxList1.DataBind();
           Page.DataBind();
        }
                   

      
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "Car")
        {
            DropDownList2.DataSource = Cars;
        }
        else if (DropDownList1.SelectedValue == "Jeep")
        {
            DropDownList2.DataSource = Jeeps;
        }
        else
        {
            DropDownList2.DataSource = Bikes;
        }
        DropDownList2.DataBind();
        DropDownList2.Visible = true;
    }
}
