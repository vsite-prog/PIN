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

    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        p1.InnerHtml = "KLik na button..";
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Label1.Text = "Promijenjeno";
        Label1.Visible = !Label1.Visible;
        Label1.ForeColor = System.Drawing.Color.DarkSalmon;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        p1.InnerHtml = "Uneseni broj je: " + tb_broj1.Text;
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        int broj1 = Int32.Parse(tb_broj1.Text);
        int broj2 = Int32.Parse(tb_broj2.Text);

        lb_rezultat.Text = "Zbroj je: " + (broj1 + broj2).ToString();
    }

    protected void DropDownList1_SelectedIndexChanged(object sender,
 EventArgs e)
    {
        double rezultat = 0;
        int broj1 = Int32.Parse(tb_broj1.Text);
        int broj2 = Int32.Parse(tb_broj2.Text);
        string operacija = DropDownList1.SelectedItem.ToString();
        switch (operacija)
        {
            case "+":
                rezultat = broj1 + broj2;
                break;
            case "-":
                rezultat = broj1 - broj2;
                break;
            case "*":
                rezultat = broj1 * broj2;
                break;
            case "/":
                if (broj2 == 0)
                {
                    lt_rezultat.Text = "Greška, dijeljenje s 0!";
                    return; //Nije baš lijep ali neka
                }
                else
                {
                    rezultat = broj1 / broj2;
                }
                break;
        }
        lt_rezultat.Text = "Rezltat je: " + rezultat.ToString();
    }
}
