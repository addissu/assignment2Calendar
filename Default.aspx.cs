using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    string[,] schedule = new string[6, 2];
    
    protected void Page_Load(object sender, EventArgs e)
    {
        schedule[0, 0] = "5/14/2017";
        schedule[0, 1] = "Meeting at Amazon at 3pm";
        schedule[1, 0] = "4/17/2017";
        schedule[1, 1] = "Brothers Birthday";
        schedule[2, 0] = "12/24/2017";
        schedule[2, 1] = "Christmas";
        schedule[3, 0] = "9/6/2017";
        schedule[3, 1] = "Sosi Bday";
        schedule[4, 0] = "10/31/2017";
        schedule[4, 1] = "Halloween";
        schedule[5, 0] = "9/6/2017";
        schedule[5, 1] = "First day of school";

    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        Label1.Text = "";
        string myDate = Calendar1.SelectedDate.ToShortDateString();

        for (int i = 0; i < 6; i++)
        {
            if (schedule[i, 0].Equals(myDate))
            {
                Label1.Text += schedule[i, 1] + "<br />";
            }
          


        }
         if(Label1.Text.Equals(""))
            {
            Label1.Text = Calendar1.SelectedDate.ToShortDateString();
            }






    }
}