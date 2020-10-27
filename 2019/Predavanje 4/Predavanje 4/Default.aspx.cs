using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) // ovo je prvo otvaranje stranice (GET)
        {
            par1.InnerHtml = "Upisano kroz kod";
        }

    }

    protected void Klikni_Me(object sender, EventArgs e)
    {
        this.par1.InnerHtml = "<strong>Ja sam novi tekst kroz kod....</strong>";
        lb_nesto.ForeColor = Color.Azure;
        lb_nesto.BackColor = Color.Yellow;
        lb_nesto.Font.Italic = true;

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        // Ne radi ništa
        lb_nesto.Visible = !lb_nesto.Visible;
        // lt_tekst.Text = "HTML source je bio: <b> Ja sam deprecetada ali me ljudi koricn sadjfbdyjsf...</b>";
        // Neka bude baš onakav tekst...
        lt_tekst.Text = Server.HtmlEncode("HTML source je bio: <b> Ja sam deprecetada ali me ljudi koricn sadjfbdyjsf...</b>");
    }

    protected void Odi_Klik(object sender, EventArgs e)
    {
        Response.Redirect("Kalkulator.aspx");
    }
}