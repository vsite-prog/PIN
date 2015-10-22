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
        //p1.InnerHtml = "Novi text!";
    }
    protected void bt_promijeni_Click(object sender, EventArgs e)
    {
        string txt = tb_nesto.Text;
        p1.InnerHtml = "<span>" + txt + "</span>";
    }
}