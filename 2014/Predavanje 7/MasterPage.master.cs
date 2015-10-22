using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            if (Session["Korisnik"] != null)
            {
                showPanel(false);
                // Pročitaj korisnika
                Korisnik k = (Korisnik)Session["Korisnik"];
                lb_odjava.Text = "Dobar dan: " + k.Naziv;
            }
            else {
                showPanel(true);
            }
        }
    }
    protected void bt_prijava_Click(object sender, EventArgs e)
    {
        //Vidi ima li korisnika
        Korisnik k = Global.imaLiKorisnika(tb_ime.Text, tb_lozinka.Text);
        if (k != null)
        {
            Session["Korisnik"] = k;
            showPanel(false);
            lb_odjava.Text = "Dobar dan: " + k.Naziv;
        }
        else
        {
            lb_greska.Text = "Nepostojeći korisnik";
        }
    }

    //Prijava ili odjava
    void showPanel(bool flag)
    {
        // pn_odjava.Visible = !flag -- kraće bi bilo
        if (flag)
        {
            pn_prijava.Visible = true;
            pn_odjava.Visible = false;
        }
        else
        {
            pn_prijava.Visible = false;
            pn_odjava.Visible = true;
        }
    }
    protected void bt_odjava_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        //Ponovo novi zahthev
        Response.Redirect(Request.Url.ToString());
    }
}
