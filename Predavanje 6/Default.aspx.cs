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
        //Vidi imali kolač i ako ima postavi boju, samo prvi put
        if (Request.Cookies["postavke"] != null && !IsPostBack)
        {
            String boja = Request.Cookies["postavke"]["boja"];
            ddl_boja
                .Items
                .FindByValue(boja)
                .Selected = true;
            promijeni_boju(boja);
        }

    }
    protected void ddl_boja_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Pročitaj iz DDL-a
        String boja = ddl_boja.SelectedValue;
        promijeni_boju(boja);
        //Novi objekt kolac
        HttpCookie cookie = new HttpCookie("postavke");
        //Dodaj kljuc = vrijednost
        cookie.Values["boja"] = boja;
        //Kad ističe
        cookie.Expires = DateTime.Now.AddDays(60);
        // POšalji sa stranicom
        Response.Cookies.Add(cookie);

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
    protected void bt_provjeri_Click(object sender, EventArgs e)
    {
        //Idi na provjeru , dodaj u Query String
        String ime = Server.UrlEncode(tb_ime.Text); //Zbog specijalnih znakova
        Response.Redirect("Provjera.aspx?q=" + ime);
    }
}