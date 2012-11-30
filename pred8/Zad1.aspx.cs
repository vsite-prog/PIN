using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class Zad1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
            ViewState["brojOtvaranja"] = 1;

        else
        {
            if (ViewState["brojOtvaranja"] != null)
                ViewState["brojOtvaranja"] = (int)ViewState["brojOtvaranja"] + 1;

        }
        Label1.Text = ViewState["brojOtvaranja"].ToString() + ". broj otvaranja";
            

    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (DropDownList1.SelectedValue == "1")
            Label1.ForeColor = Color.Red;
        else if (DropDownList1.SelectedValue == "2")
            Label1.ForeColor = Color.Blue;
        else if (DropDownList1.SelectedValue == "3")
            Label1.ForeColor = Color.Green;

    }
}