using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Druga2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Pročitaj što je u cookie-u i postavi boju
        if (!IsPostBack) //Samo kod prvog čitanja, inače čita iz ViewState-a
        {
            //Obavezno provjeriti da li kolačić postoji
            if (Request.Cookies["postavke"] != null)
            {
                string boja = Request.Cookies["postavke"]["boja"];
                postavi_boju(boja);
            }

        }
    }
        void postavi_boju(string boja)
        {
            //Idemo promujeniti boju stranice

            switch (boja)
            {
                case "Zuta": //Ovako je value u .aspx
                    body.Style["background-color"] = "yellow"; //treba nam runat=server
                    break;
                case "Crvena":
                    body.Style.Value = "background-color:red"; //drugi način dodavanja stila
                    break;
                case "Zelena":
                    body.Style["background-color"] = "green"; //treba nam runat=server
                    break;
                default:
                    body.Style.Value = "";
                    break;
            }
        }


    protected void Button1_Click(object sender, EventArgs e)
    {
        int broj = Int32.Parse(tb_broj.Text);
        //Pročitaj uneseni broj iz Query Stringa
        //int tajna = Int32.Parse(Request.QueryString["t"]); ili ne
        //Čitamo iz session-a
        if(Session["tajna"] != null)
        {
            int tajna = (int)Session["tajna"];
            if (broj == tajna)
            {
                lb_poruka.Text = "Pogodak!!!";
            }
            else if (broj > tajna)
            {
                lb_poruka.Text = "tajni broj je manji!";
            }
            else
            {
                lb_poruka.Text = "tajni broj je veći!";
            }
        } else
        {
            lb_poruka.Text = "Nema zapamćenog broja!";
        }

    }
    
}