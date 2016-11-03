using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Init(object sender, EventArgs e)
    {
        //Prije ViewState deserijalizacije
        label1.Text += Server.HtmlEncode("<Page init event>") + "<br>";
    }

    protected void Page_Load(object sender, EventArgs e)
    {
        //Stranica kakva je bila zadnji put kad je poslana (ako je postback)
        if (!IsPostBack)
        {
            label1.ForeColor = System.Drawing.Color.White;
            label1.BackColor = System.Drawing.Color.DarkMagenta;
        } else
        {
            //POništiti promjene koje smo zapamtili u Viewstate-u
            label1.ForeColor = System.Drawing.Color.Black;
            label1.BackColor = System.Drawing.Color.White;
        }
        label1.Text += Server.HtmlEncode("<Page load event>") + "<br>";

        //Mogli bi koristiti Ispostback
        if (ViewState["vrijeme"] == null) //Nema ništ apod ovim ključem
        {
            lb_viewstate.Text = "Nije bilo postbacka...";
        } else
        {
            //umjesto tostring mogli bi casta-ti (DateTime)ViewState["vrijeme"] ali nam je duže
            lb_viewstate.Text = "Vrijeme zadnjeg postback-a na servru: " + ViewState["vrijeme"].ToString();
        }
        //Spremi na stranicu sadašnje vrijeme na serveru
        ViewState["vrijeme"] = DateTime.Now;
    }
    protected void Page_PreRender(object sender, EventArgs e)
    {
        label1.Text += Server.HtmlEncode("<Page prerender event>" ) + "<br>";
    }

    protected void lb_butt1_Click(object sender, EventArgs e)
    {
        label1.Text += Server.HtmlEncode("<Button click event>" ) + "<br>";
    }

    protected void Redirect_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
}