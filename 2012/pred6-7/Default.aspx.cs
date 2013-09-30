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
        int counter;
        if (Application["brojDef"] == null)
            counter=1;
        else{
            counter = (int) Application["brojDef"];
            counter++;
           
        }
        lb_appCnt.Text = counter.ToString();
        Application.Lock();
        Application["brojDef"] = counter;
        Application.UnLock();


        
        

    }
  
    protected void DDLJezik_SelectedIndexChanged(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("Postavke");
        cookie.Values["jezik"] = DDLJezik.SelectedValue;
        cookie.Expires.AddMonths(1);
        Response.Cookies.Add(cookie);
    }
}