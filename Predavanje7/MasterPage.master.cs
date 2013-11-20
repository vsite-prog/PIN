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
        if (Session["korisnik"] == null)
            PokaziPrijavu(true);
        else
            PokaziPrijavu(false);
    }

    protected void PokaziPrijavu(bool flag)
    {
        if (flag)
        {
            prijava.Visible = true;
            odjava.Visible = false;
        }
        else {
            prijava.Visible = false;
            odjava.Visible = true;
        }
    }
    protected void bt_prijava_Click(object sender, EventArgs e)
    {
        Korisnik kor = ListaKorisnika.nadjiKorisnika(tb_kime.Text, tb_lozinka.Text);
        if (kor != null)
        {
            Session["korisnik"] = kor.Kime;
            lb_korisnik.Text = "Hello: " + kor.PunoIme;
            // Response.Redirect("Default2.aspx"); -- Ako idemo na drugu stranicu morali bi labelu postaviti preko Session state
        }
        else
        {
            lb_greska.Visible = true;
        
        }
    }
    protected void bt_odjava_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        PokaziPrijavu(true);
    }
}
