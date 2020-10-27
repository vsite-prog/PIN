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
        tb_rezultat.Enabled = false;
    }

    protected void ddl_operator_SelectedIndexChanged(object sender, EventArgs e)
    {
        double a, b;
        a = Double.Parse(tb_a.Text);
        b = Double.Parse(tb_b.Text);
        // Pročitaj koja je operacija u tijeku
        string oper = ddl_operator.SelectedItem.ToString();
        switch (oper)
        {
            case "+":
                tb_rezultat.Text = (a + b).ToString();
                break;
            case "-":
                tb_rezultat.Text = (a - b).ToString();
                break;
            case "*":
                tb_rezultat.Text = (a * b).ToString();
                break;
            case "/":
                tb_rezultat.Text = (a / b).ToString();
                break;
        }

    }
}