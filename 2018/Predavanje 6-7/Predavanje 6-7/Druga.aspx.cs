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
        //Ovo je stranica samo za prijavljene
        if (Session["ime"] == null)
            Response.Redirect("Default.aspx");

        if (!IsPostBack)
        {
            if (Request.Cookies["postavke"] != null)
            {
                //Pročitaj ono što je u kolačiću
                int index = Int32.Parse(Request.Cookies["postavke"]["pozadina"]);
                postaviPozadinu(index);
            }
        }

        //Ovo je vezan više za session
        if(Session["pozadinaIndeks"] != null)
        {
            // Pročitaj broj
            int ix = (int)Session["pozadinaIndeks"];
            // Spremi u labelu, Session podatak smo mogli prebaciti sa ToString i odmah..
            Label1.Text = ix.ToString();
        }

    }


    void postaviPozadinu(int broj)
    {
        // Ovisno o odabiru obojaj sve
        switch (broj)
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
}