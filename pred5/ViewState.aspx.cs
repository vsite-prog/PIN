using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class ViewState : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Osoba tajna = new Osoba("Barack", "Obama");
            ViewState["trazena"] = tajna;
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Osoba unesena = new Osoba(tb_ime.Text, tb_prezime.Text);
        Osoba trazena = (Osoba) ViewState["trazena"];

        if (unesena.jeliIsta(trazena))
        {
            lb_pogodak.Text = "Poooogodak!!!";
            lb_pogodak.BackColor = Color.White;
            lb_pogodak.ForeColor = Color.Black;
        }
        else
        {
            lb_pogodak.Text = "Pogrešno";
            lb_pogodak.BackColor = Color.Red;
            lb_pogodak.ForeColor = Color.White;

        }



    }
}