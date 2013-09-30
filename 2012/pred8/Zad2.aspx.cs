using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zad2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
       if (tb_grad.Text == "New York") {
           HttpCookie cookie = new HttpCookie("grad");
           cookie.Values.Add("naziv", Session["grad"].ToString());
           cookie.Expires.AddDays(60);
           Response.Cookies.Add(cookie);
           Response.Redirect("newyork.aspx");
       }
       else
          Session["grad"] = tb_grad.Text;

    }
}