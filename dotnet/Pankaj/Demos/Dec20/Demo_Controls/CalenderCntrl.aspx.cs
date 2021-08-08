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

public partial class Calender : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "You have selected date/dates: <br>";

        Label1.Text += Calendar1.SelectedDates[Calendar1.SelectedDates.Count - 1].ToShortDateString();
        for (int i = 0; i < Calendar1.SelectedDates.Count - 1; i++)
        {

            
            //Label1.Text += Calendar1.SelectedDates[i].ToShortDateString() + "<br>";
        }
        
        
        //Label1.Text += Calendar1.SelectedDate.ToShortDateString();
        // Label1.Text = Label1.Text + Calendar1.SelectedDate.ToString();
    }
}
