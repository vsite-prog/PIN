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
            tb_veliki.Text = "Ovo je HTML Text area";
            p1.InnerHtml = Server.HtmlEncode(" U HTMLu trebalo bi biti: <strong> Novi text </strong>");
        }
      //  lb_nesto.Text = "Nešto drugo";

    }
    protected void bt_postback_Click(object sender, EventArgs e)
    {
        p1.InnerHtml += "<br> Unijeli ste: " + DateTime.Now.ToString() + " " + tb_normalni.Text;
        lb_nesto.ForeColor = System.Drawing.Color.Red;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        p1.InnerHtml += "Odabrali ste:" + DropDownList1.SelectedValue + ". opciju <br>";
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        p1.InnerHtml = "<strong> Kliknuli ste na link </strong>";
    }
}