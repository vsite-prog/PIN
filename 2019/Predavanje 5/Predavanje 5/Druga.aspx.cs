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
        // Čitaj iz URL-a podatke, kao i u klasičnom SP-u 
        Label1.Text = Request.QueryString["text"];

        // Citaj iz kolaca
        if(Request.Cookies["Oreo"] != null)
        {
            lb_kolac.Text = "Datum iz kolačića: " + Request.Cookies["Oreo"]["datum"];
        }
    }
}