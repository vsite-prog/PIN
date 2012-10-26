using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class PageEvents : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        txtEvents.Text += "Stranica učitana!" + "\n";

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        txtEvents.Text += "Klik mišom!" + "\n";
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtEvents.Text += "promijenjen DDL izbor" + "\n";
    }
}