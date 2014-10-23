using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Calc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        tb_rez.Enabled = false;
        lb_greska.Text = "";
        tb_rez.Text = "";
    }
    protected void bt_izracun_Click(object sender, EventArgs e)
    {
        int oper1, oper2;
        double rez;

        if (!Int32.TryParse(tb_oper1.Text, out oper1) || !Int32.TryParse(tb_oper2.Text, out oper2))
        {
            lb_greska.Text = "Svi operandi nisu brojevi";
            return;
        }
        if (ddl_oper.SelectedValue == "+")
        {
            rez = (double)oper1 + oper2;
        }else if (ddl_oper.SelectedValue == "-"){
            rez = (double)oper1 - oper2;
        }
        else if (ddl_oper.SelectedValue == "*")
        {
            rez = (double)oper1 * oper2;
        }
        else
        {
            if (oper2 == 0)
            {
                lb_greska.Text = "Dijeljenje sa 0!";
                return;
            }

            rez = oper1 / oper2;
        }

        tb_rez.Text = rez.ToString();
    }
} 