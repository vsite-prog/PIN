using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class pogodi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        lb_rez.Text = "";
    }
    protected void bt_provjeri_Click(object sender, EventArgs e)
    {
        string osoba = tb_ime.Text + " " + tb_prezime.Text, zapamti = "";
        if (Session["osoba"] != null)
            zapamti = Session["osoba"].ToString();

        if (osoba == zapamti)
            Response.Redirect("Default.aspx");
        else
            lb_rez.Text = "Kriva osoba";
    }
}