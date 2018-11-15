using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void But_Click(object sender, EventArgs e)
    {
        //Pročitaj broj i pošalji preko QueryStringa
        string url = "Default3.aspx?broj=" + tb_broj.Text;
        //Response redirect
        Response.Redirect(url);
    }
}