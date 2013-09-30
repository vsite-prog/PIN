using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            Button1.Font.Bold = true;
            lb_postback.Text = "1";
            lb_postback.Font.Bold = true;

        }
        //else
        //    lb_postback.Text = Convert.ToString(Convert.ToInt32(lb_postback.Text) + 1);
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        int broj = Convert.ToInt32(lb_postback.Text);

        if (broj == 2)
            lb_postback.ForeColor = Color.BlueViolet;
        else if (broj > 3)
            lb_postback.ForeColor = Color.Green;
        else if (broj > 4)
            lb_postback.ForeColor = Color.Black;


        lb_postback.Text = Convert.ToString(broj  + 1);
    }
}