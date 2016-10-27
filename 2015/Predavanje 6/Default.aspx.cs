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
        if (!Page.IsPostBack)
        {
            if (Request.Cookies["postavke"] != null) //check if cookie exists, avoid exception
                promijeniBoju(Request.Cookies["postavke"]["boja"]); //read cookie
            //It would be better to change drop down list value but we are lazy
        }
    }

    protected void ddl_boja_SelectedIndexChanged(object sender, EventArgs e)
    {
        promijeniBoju(ddl_boja.SelectedValue);
        
    }

    void promijeniBoju(string boja)
    {
        //Change color of background
        switch (boja)
        {
            case "Crvena":
                body.Attributes["style"] = "background-color:red;";
                break;
            case "Roza":
                body.Attributes["style"] = "background-color:pink;";
                break;
            case "Zelena":
                body.Attributes["style"] = "background-color:green;";
                break;
            default:
                body.Attributes["style"] = "background-color:white;";
                break;
        }

        //Save to cookie
        HttpCookie cookie = new HttpCookie("postavke");
        cookie.Values["boja"] = boja; //save color name to cookie values
        cookie.Expires = DateTime.Now.AddMonths(2);  // Keep cookie for two months
        // cookie.Expires = DateTime.Now.AddDays(-1); // get rid of cookie
        Response.Cookies.Add(cookie); //include in postback

    }

    protected void lb_odi_dalje_Click(object sender, EventArgs e)
    {
        //Save to session and go on
        Session["boja"] = ddl_boja.SelectedValue;
        Response.Redirect("Default2.aspx");
    }
}