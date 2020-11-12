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
        if (!IsPostBack) // Samo kad nije postback, već je riječ o prvom otvaranju stranice      
        {   
            // Idemo čitati cookie
            if (Request.Cookies["postavke"] != null)
            {
                // Uvijek provjerite je li kolac postoji prije čitanja
                string boja = Request.Cookies["postavke"]["boja"]; // POdatak u kolacu je uvijek tekst
               // promijeni_boju(boja);
                ddl_boja.SelectedItem.Text = boja;
            }
        }


    }

    protected void Boja_SelectedIndexChanged(object sender, EventArgs e)
    {
        string boja = ddl_boja.SelectedItem.ToString();
        promijeni_boju(boja);
        // Kreirajmo novi objekt i pripremo kolac za slanje
        HttpCookie kolacic = new HttpCookie("postavke");
        kolacic.Values.Add("boja", boja);
        kolacic.Expires = DateTime.Now.AddDays(30); // Kolacic je ziv kod browsera nekih 30 dana
        // Treba ga dodati u stranicu koja se šalje korisniku
        Response.Cookies.Add(kolacic);
    }

    void promijeni_boju(string boja)
    {
        switch (boja)
        {
            case "Crvena":
                body.Style.Add("background-color", "red");
                break;
            case "Plava":
                body.Style.Add("background-color", "blue");
                break;
            case "Zelena":
                body.Style.Add("background-color", "green");
                break;
            default:
                body.Style.Add("background-color", "white");
                break;
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (Session["tajniBroj"] != null) // Nema broja za pogađanje
        {
            int tajniBroj = (int)Session["tajniBroj"]; // ne zaboravite cast
            int broj = Int32.Parse(tb_broj.Text);
            if (tajniBroj == broj)
            {
                lb_poruka.Text = "Bravo, pogodili ste broj!";
                // Prekini cijelu sesiju
                Session.Abandon();
            } else if (tajniBroj < broj)
            {
                lb_poruka.Text = "Traženi broj je manji!";
            } else
            {
                lb_poruka.Text = "Traženi broj je veći!";
            }
        } else
        {
            Response.Redirect("Druga.aspx");
        }
    }
}