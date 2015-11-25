using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Unos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Accept message from other page
            string msg = Request.QueryString["msg"];
            if (msg != null)
                lb_greska.Text = msg;
        }

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Save number to session state
        int broj;
        //Check if it is int in 0-100 interval
        if (Int32.TryParse(tb_broj.Text, out broj) && broj > 0 && broj < 100)
        {
            Session["pogodiMe"] = broj;
            //No try to guess number
            Response.Redirect("Default.aspx");
        } else
        {
            lb_greska.Text = "Nije broj od 1 -100!";
        }
    }
}