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

    protected void ddl_boja_SelectedIndexChanged(object sender, EventArgs e)
    {
        string boja = ddl_boja.SelectedValue.ToString();
        //Idemo spremiti odabir korisnika u kolač
        HttpCookie kolacic = new HttpCookie("postavke");
        kolacic.Values["boja"] = boja;
        kolacic.Expires = DateTime.Now.AddDays(30);
        //Ovo još ne ide kao kolačić
        Response.Cookies.Add(kolacic);

        postavi_boju(boja);

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

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int broj = Int32.Parse(tb_tajna.Text); //Ako ne unese broj booom, nema validacija
        //Response.Redirect("Druga.aspx?t=" + broj.ToString()); zgodno ali nije tajno
        Session["tajna"] = broj;
        Response.Redirect("Druga.aspx");


    }
}