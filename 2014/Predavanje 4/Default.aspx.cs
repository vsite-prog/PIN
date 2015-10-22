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
        lbl_txt.Text = "Unesi nešto:";
        p_txt.InnerHtml = "Ovo je <br> break!!";

        if (!IsPostBack)
        {
            TextArea1.Value = "Ovo je prvo otvaranje";
            lbl_txt.ForeColor = System.Drawing.Color.Red;
        }

        if (Page.IsPostBack)
        {
            bt_nest.BackColor = System.Drawing.Color.Pink;
        }
  
    }


    protected void bt_nest_Click(object sender, EventArgs e)
    {
        p_txt.InnerHtml += "<br> Ide tekst: " + tb_txt.Text;
        TextArea1.Value += tb_txt.Text;
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        p_txt.InnerHtml += "<br> Selektirali ste: " + DropDownList1.SelectedValue;
    }
}