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
        if (Request.Cookies["postavke"] != null)
        {
            string boja = Request.Cookies["postavke"]["boja"];
            oboji(boja);
        }

    }
    protected void ddl_boja_SelectedIndexChanged(object sender, EventArgs e)
    {
        string boja = ddl_boja.SelectedValue;
        oboji(boja);
        HttpCookie kolacic = new HttpCookie("postavke");
        kolacic.Values.Add("boja", boja);
        kolacic.Expires = DateTime.Now.AddYears(1);
        Response.Cookies.Add(kolacic);
    }

    protected void oboji(string boja)
    {
        switch (boja)
        {
            case "bijela":
                PageBody.Style["background-color"] = "white";
                break;
            case "crvena":
                PageBody.Style["background-color"] = "red";
                break;
            case "plava":
                PageBody.Style["background-color"] = "blue";
                break;
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Session["osoba"] = DropDownList1.SelectedValue;
        Response.Redirect("pogodi.aspx");
    }
}