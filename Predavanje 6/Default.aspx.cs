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
        //Inače će drugi event promijeniti boju
        if (!Page.IsPostBack)
        {
            //provjeri ima li cookie-a možd ga je i user disable-o
            if (Request.Cookies["postavke"] != null)
            {
                string boja = Request.Cookies["postavke"]["boja"];
                ddl_boja.SelectedValue = boja;
                promijeniBoju(boja);
            }
        }

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Koristimo jednostavan QueryString mehanizam
        Response.Redirect("Druga.aspx?pojam=" + Server.UrlEncode(tb_pojam.Text));
    }

    protected void ddl_boja_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Spremi odabirr u cookie i promijeni boju
        string boja = ddl_boja.SelectedValue.ToString();
        //Novi kolač
        HttpCookie cookie = new HttpCookie("postavke");
        //dodaj neku vrijednost 
        cookie.Values.Add("boja", boja);
        //dodasj još
        cookie.Values.Add("vrijeme", DateTime.Now.ToString());
        //Persistent cookie
        cookie.Expires = DateTime.Now.AddDays(60);
        //Bitno dodaj cookie u response
        Response.Cookies.Add(cookie);
        promijeniBoju(boja);
    }

    private void promijeniBoju(string boja)
    {
        //Promijeni boju stranice
        switch (boja)
        {
            case "Crvena":
                body.Style["background-color"] = "red";
                break;
            case "Plava":
                body.Style["background-color"] = "blue";
                break;
            case "Roza":
                body.Style["background-color"] = "pink";
                break;
            default:
                body.Style.Remove("background-color");
                break;
        }
    }
}