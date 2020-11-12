using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Druga : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        // Jednostavno se piše u Session state
        Session["tajniBroj"] = Int32.Parse(tb_brpj.Text); // Nije idealan kod, Exception ako nije dobar unos
        Response.Redirect("Default.aspx");
    }
}