using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    // int brojac = 0; Problem,  briše se svaki put, ne radi
    protected void Page_Load(object sender, EventArgs e)
    {
        int brojac = 0;
        //??? brojac++;
        if (!IsPostBack)
        {
            lb_poruka.Text = "Dobro došli po prvi put!";
            lb_poruka.ForeColor = Color.Aquamarine;
        }
        else
        {
            brojac = (int)ViewState["brojac"];
            lb_poruka.Text = "Dobro došli ponovo!" + brojac.ToString();
            lb_poruka.ForeColor = Color.Violet;
        }
        brojac++;
        ViewState["brojac"] = brojac;

    }
    protected void lb_racunaj_Click(object sender, EventArgs e)
    {
        int a, b;
        double rez = 0;
        // oVO ĆE BITI exceptiona = Int32.Parse(tb_a.Text);
        if (Int32.TryParse(tb_a.Text, out a) && Int32.TryParse(tb_b.Text, out b))
        {
            switch (ddl_oper.SelectedValue)
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
                case "/":
                    if (b == 0)
                    {
                        lb_poruka.Text = "Nisu brojevi!";
                        break;
                    }

                    rez = a / b;
                    break;
            }
        }
        else
        {
            lb_poruka.Text = "Nisu brojevi!"; //Greška u try parse
            lb_poruka.ForeColor = Color.Red;
        }
        lb_reza.Text = rez.ToString();
    }
}