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

        if (!IsPostBack)
        {
            //brojac = 0; // ovo nije potrebno
        }
        else
        {
            int brojac;
            if (ViewState["brojac"] != null)
            {
                // Čitanje, kastamo u odgovarajući tip
                brojac = (int)ViewState["brojac"];
                brojac++;
            }
            else
            {
                brojac = 1;
            }

            lb_postback.Text = "Postback broj: <strong>" + brojac.ToString() + "!</strong>";

            // Upiši u ViewState, prim abilo koji tip podataka
            ViewState["brojac"] = brojac;
        }

    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        // POšalji podatke u drugu stranice, prebaci znakove u URL dio
        Response.Redirect("Druga.aspx?text=" + Server.UrlEncode("POstback iz druge stranice br:" + ViewState["brojac"].ToString() + "!"));
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        // Spremi u kolačić
        HttpCookie kolacic = new HttpCookie("Oreo");
        kolacic.Values["datum"] = DateTime.Now.ToLongDateString();
        kolacic.Expires = DateTime.Now.AddDays(8);
        // Ovo je samo kod nas popalji ovo klijentu
        Response.Cookies.Add(kolacic);
    }
}