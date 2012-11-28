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
        hideLogin();
        lb_greska.Text = "";
 

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Korisnik kor = ListaKorisnika.nadjiKorisnika(tb_kime.Text,tb_lozinka.Text );

        if (kor != null)
        {
            Session["kime"] = tb_kime.Text;
            Session["punoIme"] = kor.PunoIme;
            lb_kPunoIme.Text = kor.PunoIme;
            hideLogin();
        }
        else
        {
            Session.Abandon();
            hideLogin();
            lb_greska.Text = "Krivo korisničko ime!";
        }
  

    }

    protected void hideLogin()
    {
        if (Session["kime"] != null)
        {
            divLogin.Visible = false;
            divLogout.Visible = true;
        }
        else
        {
            divLogin.Visible = true;
            divLogout.Visible = false;
        }
    }

    protected void Linkbutton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        hideLogin();
    }
}
