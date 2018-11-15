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
            int brojac;
            //Idemo Vidjeti koje je ovo otvaranje od svih korisnika
            if (Application["brojac"] == null)
            {
                brojac = 1;
            } else
            {
                brojac = (int)Application["brojac"];
                brojac++;
            }
            Application.Lock();
            Application["brojac"] = brojac;
            // Obavezno unlock
            Application.UnLock();
            lb_aplikacija.Text = "Otvaranje ukupno broj: " + brojac.ToString();

            if (Request.Cookies["postavke"] != null)
            {
                //Pročitaj ono što je u kolačiću
                int index = Int32.Parse(Request.Cookies["postavke"]["pozadina"]);
                ddl_pozadina.SelectedIndex = index;
                postaviPozadinu();
            } else
            {
                // Default pozadina
                ddl_pozadina.SelectedIndex = 2;
            }
        }
        //Vidi što ćeš prikazati za login
        sakrij();

    }

    protected void ddl_pozadina_SelectedIndexChanged(object sender, EventArgs e)
    {
        // Spremi korisnički odabir u kolač
        HttpCookie kolacic = new HttpCookie("postavke");
        // idemo nešto zapisati u njega
        kolacic.Values["pozadina"] = ddl_pozadina.SelectedIndex.ToString();
        // Idemo ga spremiti na disk da traje mjesec dana
        kolacic.Expires = DateTime.Now.AddDays(30);
        // Ovo je zasada samo u programu, idemo ga poslati klijentu
        Response.Cookies.Add(kolacic);
        // Bojaj
        postaviPozadinu();
        //Spremi u session našu pozadinu
        Session["pozadinaIndeks"] = ddl_pozadina.SelectedIndex;
    }

    void postaviPozadinu() {
        // Ovisno o odabiru obojaj sve
        switch (ddl_pozadina.SelectedIndex)
        {
            case 0:
                body.Style["background-color"] = "red";
                break;
            case 1:
                body.Style["background-color"] = "blue";
                break;
            default:
                body.Style["background-color"] = "white";
                break;
        }

    }

    protected void Prijava_Click(object sender, EventArgs e)
    {
        //Provjeri da li je prijavljen
        if(Lista.ImaKorisnika(tb_ime.Text, tb_lozinka.Text))
        {
            //Ovim ga prijavljujemo u naš sustav
            Session["ime"] = tb_ime.Text;
            sakrij();
        } else
        {
            lb_greska.Text = "Nema korisnika";
        }

    }

    protected void lb_odjava_Click(object sender, EventArgs e)
    {
        // Molim prekini sesiju
        Session.Abandon();
        // Bilo bi bolje za prerender
        sakrij();
    }

    void sakrij()
    {
        // Idemo vidjeti je li korisnik prijavljen 
        if (Session["ime"] != null)
        {
            pn_odjava.Visible = true;
            pn_prijava.Visible = false;
            lb_prijava.Text += Session["ime"].ToString();
        }
        else
        {
            pn_odjava.Visible = false;
            pn_prijava.Visible = true;
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        throw new Exception("Nešto je puuuuuklo!!!!!");
    }
}