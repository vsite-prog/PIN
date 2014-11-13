using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Provjera : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Vidi imali kolač i ako ima postavi boju, samo prvi put
        if (Request.Cookies["postavke"] != null && !IsPostBack)
        {
            String boja = Request.Cookies["postavke"]["boja"];
            promijeni_boju(boja);
        }

        if (Session["ime"] == null)
        {
            //Session je prazan
            lb_provjera.Text = "Ništa nije zapamćeno;";
            lb_provjera.ForeColor = Color.Red;
        }
        else
        {
            int brojac;
            //Procitaj brojac i uvecaj za 1
            if (Session["brojac"] == null)
                brojac = 1;
            else
                brojac = (int)Session["brojac"] + 1;


            //Vidi pojam koji provjeravaš
            String ime = Server.UrlDecode(Request.QueryString["q"]);
            //Pročitaj iz Session-a tajno ime
            String zapIme = Session["ime"].ToString();
            if (ime == zapIme)
            {
                //POgodak
                lb_provjera.Text = "Jupiii, ime: " + ime + " je točno, br. pokušaja: " + brojac.ToString();
                //resetitraj brojac
                Session["brojac"] = null;
            }
            else
            {
                //Session je prazan
                lb_provjera.Text = "Krivo ime: " + ime;
                lb_provjera.ForeColor = Color.Red;
            }
            //spremi brojac
            Session["brojac"] = brojac;

        }

    }
    private void promijeni_boju(String b)
    {
        //POstavi boju pozadine
        switch (b)
        {
            case "Žuta":
                PageBody.Style["background-color"] = "yellow";
                break;
            case "Zelena":
                PageBody.Style["background-color"] = "green";
                break;
            default:
                PageBody.Style.Remove("background-color");
                break;

        }
    }
}