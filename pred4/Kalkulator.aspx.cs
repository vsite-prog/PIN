using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kalkulator : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtBroj1.Text = "0";
            txtBroj2.Text = "0";
        }

    }
    protected void btnRacunaj_Click(object sender, EventArgs e)
    {
        double broj1, broj2, rez = 0;
        broj1 = Convert.ToDouble( txtBroj1.Text);
        broj2 = Convert.ToDouble(txtBroj2.Text);
        if (DDLOper.Text == "+")
            rez = broj1 + broj2;
        else if (DDLOper.Text == "-")
            rez = broj1 - broj2;
        else if (DDLOper.Text == "*")
            rez = broj1 * broj2;
        else if (DDLOper.Text == "/")
            rez = broj1 / broj2;


        lblRezultat.Text = Convert.ToString(rez);
    }
}