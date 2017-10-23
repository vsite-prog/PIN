using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zastita : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       //Da li je prijavljen
        if (Session["korisnik"] == null) //KOrisnik nije prijavljen
        {
            Response.Redirect("Prijava.aspx");
        }
        else //pRIJAVLJEN JE , može ući
        {
            Label1.Text = "KOrisnik: " + Session["korisnik"].ToString();
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Prijava.aspx");
    }
}