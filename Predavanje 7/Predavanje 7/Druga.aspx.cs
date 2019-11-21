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
        if (Session["korisnik"] != null)
        {
            // Radi malo drugačije , ode naš aspx Markup
            Response.Write("Pozdrav " + Session["korisnik"].ToString());
        } else
        {
            // Nisi prijavljen, ne puštam 
            Response.Redirect("Default.aspx");
        }
    }
}