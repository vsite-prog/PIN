using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        provjeriKorisnika();
    }

    protected void lb_odjava_Click(object sender, EventArgs e)
    {
        //Ubijamo sesiju, sve varijable SS-a su prazne
        Session.Abandon();
        provjeriKorisnika();
    }

    void provjeriKorisnika()
    {
        if (Session["user"] == null)
        {
            Response.Redirect("Login.aspx");
        }
        else
        {
            User user = (User)Session["user"];
            lb_user.Text = "KOrisnik: " + user.FullName;
            // Staro: lb_user.Text = "KOrisnik: " + Session["user"].ToString();
        }
    }
}