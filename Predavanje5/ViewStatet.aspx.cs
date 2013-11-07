using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ViewStatet : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ( !Page.IsPostBack )
            Label1.ForeColor = System.Drawing.Color.Red;

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        if (ViewState["dugme1"] == null) //provjeri da li postoji VS tipa dugme1
            ViewState["dugme1"] = 1;
        else
         ViewState["dugme1"] = (int)ViewState["dugme1"] + 1;

        Label1.Text = "Kliknuli ste na dugme1: " + ViewState["dugme1"].ToString() + ".puta!";
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        string stariPojam = "";
        if ( ViewState["pojam"] != null) //vidi da li postoji
            stariPojam = ViewState["pojam"].ToString();

        lb_unos.Text = "Unijeli ste prosli put: " + stariPojam + " a sad: " + tb_pojam.Text;
        ViewState["pojam"] = tb_pojam.Text;
    }
}