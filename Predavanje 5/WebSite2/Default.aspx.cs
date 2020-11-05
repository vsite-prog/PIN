using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack) // Samo prvo otvaranje stranice
        {
            dugme1.BackColor = Color.BlanchedAlmond;
        } else // Ovo je postback, korisnik i ne sluti da smo opet ovdje 
        {
            int i = 0;
            // Ovaj kod nije ni malo optimalan, pokušajte ga optimizirati
            if (ViewState["brojPostbacka"] == null) // Nije ništa u VS-u
            {
                i = 1;
                ViewState["brojPostbacka"] = i;
            } else // već je bio postback prije
            {
                i = (int)ViewState["brojPostbacka"];
                i++;
                ViewState["brojPostbacka"] = i;
            }
            labela1.Text += "<br> Postback broj: " + i.ToString();
        }
    }

    protected void dugme1_Click(object sender, EventArgs e)
    {
        labela1.Text += "<br> Klik na dugme  tekst!";
    }
    protected void dugme2_Click(object sender, EventArgs e)
    {
        string text = tb_unos.Text;
        // ViewState["text"] = text; ovo neće nikako raditi
       
        Response.Redirect("Druga.aspx?txt="+ Server.UrlEncode(text));
    }
}