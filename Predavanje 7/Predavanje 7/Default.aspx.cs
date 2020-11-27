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
        // Samo za prvo otvaranje
        if (!IsPostBack)
        {
            int otvaranje = 0;
            if (Application["otvaranje"] != null)
            {
                otvaranje = (int)Application["otvaranje"];
            }
            otvaranje++;
            Application.Lock(); // Ako istovremeno idemo pisati od strane više korisnika (zahtjeva)
            Application["otvaranje"] = otvaranje;
            Application.UnLock();
            lb_poruka.Text = "Ovo je otvaranje (od bilo kog korisnika) broj: " + otvaranje.ToString();
        }

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        throw new Exception("Boooooooooooooooooooooooom!!!!!");
        if (tb_korisnik.Text == "ivica" && tb_lozinka.Text == "1234")
        {
            // Zapamti koje je korisnikovo ime u SessionState-u
            Session["korisnik"] = tb_korisnik.Text;
            LinkButton1.Text = "Odjava";
        } else
        {
            Session.Abandon(); // Ubij sesiju
            LinkButton1.Text = "Prijava";
        }
    }
}