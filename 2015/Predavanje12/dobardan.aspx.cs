using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dobardan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["ime"]!= null) //Logged in
        {
            Label1.Text = "Dobar dan: " + Session["ime"].ToString();
        } else
        {
            Response.Redirect("login.aspx");
        }
    }
}