using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LogiraniKorisnici : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["korisnik"] != null)
            //logiran
            Label1.Text = "Dobar dan " + Session["korisnik"].ToString() + "!";
        else
            // Logiraj se pa dođi
            Response.Redirect("Login.aspx");

    }
}