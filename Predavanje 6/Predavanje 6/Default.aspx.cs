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
        // Ako otvaramo po prvi put (GET)
        if (!IsPostBack)
        {
            // Čitaj kolačić iz Requesta!
            if (Request.Cookies["postavke"] != null)  // Obvezno provjeriti prije čitanja da li ga ima
            {
                string boja = Request.Cookies["postavke"]["boja"];
                obojaj(boja);
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        string boja = ddl_pozadina.SelectedItem.Value;
        obojaj(boja);

        // Spremi u Cookie da imamo i dalje
        Response.Cookies["postavke"]["boja"] = boja;
        Response.Cookies["postavke"].Expires = DateTime.Now.AddDays(60);
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

    protected void Unnamed1_Click(object sender, EventArgs e)
    {
        int pokusaj;
        if (Session["pokusaj"] == null)
        {
            pokusaj = 1;
        } else
        {
            pokusaj = (int)Session["pokusaj"];
            pokusaj++;
        }
        // Idemo spremiti u session
        Session["pokusaj"] = pokusaj;
        // Kod čitanja iz Session-a trebalo bi provjeriti je li išta zapisano
        if (Session["broj"] == null)
        {
            Response.Redirect("Druga.aspx");
        } else
        {
            int uneseno = Int32.Parse(tb_unos.Text); // Bolje bi bilo TryParse ili hvatati exception
            int spremljeno = (int)Session["broj"];
            if(spremljeno == uneseno)
            {
                lb_poruka.Text = "Bravo, pogodak iz " + pokusaj.ToString() + " puta!";
                // Oboji normalno
                lb_poruka.ForeColor = System.Drawing.Color.Black;

            } else if (uneseno > spremljeno)
            {
                lb_poruka.Text = "Traženi broj je manji!";
                lb_poruka.ForeColor = System.Drawing.Color.Red;
            } else
            {
                lb_poruka.Text = "Traženi broj je veći!";
                lb_poruka.ForeColor = System.Drawing.Color.DarkRed;
            }
        }
    }
}