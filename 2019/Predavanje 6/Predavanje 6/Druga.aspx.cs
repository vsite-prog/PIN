using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Druga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Ako otvaramo po prvi put (GET)
        if (!IsPostBack)
        {
            // Čitaj kolačić iz Requesta!
            if (Request.Cookies["postavke"] != null)  // Obvezno provjeriti prije čitanja da li ga ima
            {
                string boja = Request.Cookies["postavke"]["boja"];
                obojaj(boja);
            }
            Session.Abandon(); // Ubija sesiju, nema je više
        }
    }

    void obojaj(string boja)
    {
        switch (boja)
        {
            case "Crvena":
                body.Style["background-color"] = "red";
                break;
            case "Plava":
                body.Style["background-color"] = "blue";
                break;
            case "Zelena":
                body.Style["background-color"] = "green";
                break;
            default:
                body.Style["background-color"] = "white";
                break;
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int broj = Int32.Parse(tb_broj.Text); // Parsiraj u broj, mana je što će biti exception ako nije broj
        if (broj > 100 || broj < 0)
        {
            // Daj neku poruku
        } else
        {
            // Pisanje ne može biti jednostavnije
            Session["broj"] = broj;
            Response.Redirect("Default.aspx");
        }

    }
}