using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cookie : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //samo prijavljene korisnike pustiti na stranicu
        if (Session["kime"] == null)
            Response.Redirect("Default.aspx");


        HttpCookie cookie = Request.Cookies["Postavke"];
        if (cookie != null)
            DropDownList1.SelectedValue = cookie["jezik"];



    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       
    }
}