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
        //Idemo staviti vrijeme otvaranja stranice
        //Htjeli bi da ovo radi samo prvi put
        if (!IsPostBack)
        {
            lb_status.Text = DateTime.Now.ToShortTimeString();
        }

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        lb_status.Text = tb_unos.Text;
        lb_status.ForeColor = System.Drawing.Color.Yellow;
        lb_status.BackColor = System.Drawing.Color.Blue;

        Literal1.Text += Server.HtmlEncode( "Ovo je kliknuto!<br>"); //želimo točno ovakav tekst

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Idemo izračunati rez i staviti ga u TB
        double a, b, rez;
        // a = tb_broj1; Ovo nema smisla, zašto?
        a = Double.Parse(tb_broj1.Text); //Iako bi bio bolji try parse
        b = Double.Parse(tb_broj2.Text);
        switch (ddl_operator.SelectedValue) //Pročitaj iz DDL
        {
            case "+":
                rez = a + b;
                break;
            case "-":
                rez = a - b;
                break;
            case "*":
                rez = a * b;
                break;
            case "/": //Dijeljenje s 0 je exception
                rez = a / b;
                break;
            default:
                tb_rezultat.Text = ""; // Nema rezultata
                return;
        }
        tb_rezultat.Text = rez.ToString(); // ToString radi svugdje u C#
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        lb_status.Visible = !lb_status.Visible;
    }
}