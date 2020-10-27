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

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        double b1 = Double.Parse(broj_1.Text);
        double b2 = Double.Parse(broj_2.Text);
        double rezultat;
        string operand = ddl_operand.SelectedValue.ToString();
        switch (operand)
        {
            case "+":
                rezultat = b1 + b2;
                break;
            case "-":
                rezultat = b1 - b2;
                break;
            case "*":
                rezultat = b1 * b2;
                break;
            default:
                rezultat = b1 / b2;
                break;
        }

        labela_rezultata.Text = " = " + rezultat;

    }
}