using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ZaPrijavljene : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(Session["korisnik"] != null)
        {
            // Prijavljen je korisnik može doći
            Label1.Text = "Dobro došao: " + Session["korisnik"].ToString() + "!";
        } else
        {
            // Obvezna prijava
            Response.Redirect("Default.aspx");
        }
    }
}