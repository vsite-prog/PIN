using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        i++;
        if (!IsPostBack)
        {
            lb_za_igru.Text += "Novo vrijeme: " + DateTime.Now.ToLongTimeString();
            mojaLabela.BackColor = Color.Aqua;
        }
        else
        {
            p1.InnerHtml = "Postback broj: <b>" + i.ToString() + "</b>";
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // mojaLabela.Text = "Novi tekst";
        mojaLabela.Text = tb_uneseni_text.Text;
        Literal1.Text = "<p> Novi <b>paragraf</b> </p>";
        Literal1.Text += Server.HtmlEncode("<p> Novi <b>paragraf</b> </p>");
        // p1.InnerHtml = "<b> Nešto </b>";
        // div1.InnerHtml = "Hellou!";

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Kalkulator.aspx");
    }
}