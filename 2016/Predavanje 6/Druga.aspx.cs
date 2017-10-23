using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Druga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Ima li podataka u URL-u
        if (Request.QueryString["pojam"]!= null)
        {
            label1.Text = "Poslani pojam je: " + Request.QueryString["pojam"];
        }
        //provjeri ima li cookie-a možd ga je i user disable-o
        if (Request.Cookies["postavke"]!= null)
        {
            promijeniBoju(Request.Cookies["postavke"]["boja"]);
            label1.Text += "<br>Kolačić kreiran: " + Request.Cookies["postavke"]["vrijeme"];
        }
    }

    private void promijeniBoju(string boja)
    {
        //Promijeni boju stranice
        switch (boja)
        {
            case "Crvena":
                body.Style["background-color"] = "red";
                break;
            case "Plava":
                body.Style["background-color"] = "blue";
                break;
            case "Roza":
                body.Style["background-color"] = "pink";
                break;
            default:
                body.Style.Remove("background-color");
                break;
        }
    }
}