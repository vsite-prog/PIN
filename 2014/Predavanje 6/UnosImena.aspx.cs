using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UnosImena : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void bt_provjeri_Click(object sender, EventArgs e)
    {
        Session["ime"] = tb_ime.Text;
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Briši sesiju iz memorije
        Session.Abandon();
    }
}