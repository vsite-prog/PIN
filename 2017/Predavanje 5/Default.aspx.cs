using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    int brojac; //Ovaj Brojač se svaki put iznova kreira u našoj stranici
    protected void Page_Init(object sender, EventArgs e)
    {
        Label1.Text += "Init Event <br>";
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Label1.Text += "Load Event <br>";
        if (IsPostBack)
        {
            if (ViewState["otvaranje"] != null) //Vidi je li što spremano pod ovim ključem
            {
                brojac = (int)ViewState["otvaranje"];
                brojac++; //svaki postback inkrementiraj brojač
            } else
            {
                brojac = 1; //prvi postback
            }

            //Da bi ova promjena bila implemetirana treba nam ViewState
            ViewState["otvaranje"] = brojac; //Ovdje može biti bilo kakav objekt
        }
    }

    protected void Page_Prerender(object sender, EventArgs e)
    {
        Label1.Text += "Prerender Event <br>";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text += "Button Click Event <br>";
        //Ovo j emoglo biti i bez globalnih varijabli
        lb_postback.Text = "Ovo je " + brojac.ToString() + ". otvaranje po redu!" ;
        //idemo vidjeti koje smo sve brojeve unijeli dosad u TBox
        if (ViewState["tbox"]== null)
        {
            lb_postback.Text += "<br>Dosad nema unesenih brojeva prije ovog kojeg vidite ispod!";
            ViewState["tbox"] = tb_broj.Text;
        } else
        {
            lb_postback.Text += "<br>Dosad uneseni brojevi su: " + ViewState["tbox"].ToString();
            //Zapamti za idući put vrijednosti
            ViewState["tbox"] =  tb_broj.Text + ", " + ViewState["tbox"].ToString();
        }

    }
}