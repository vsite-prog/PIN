using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) //Dovoljno ga je prvi put upisati a postback-ovi pamte kroz ViewState
        {
            string broj = Request.QueryString["broj"]; //string, ne provjeravamo da li je broj
            lb_broj.Text += broj;
        }

    }
}