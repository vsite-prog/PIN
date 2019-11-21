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
        // Zapamti koje je ovo otvaranje
        if (!IsPostBack) //Ne brojimo postbackove
        {
            int otvaranje = 0;
            // Ima li išta u applicationu
            if(Application["otvaranje"] != null)
            {
                 otvaranje = (int)Application["otvaranje"];
            }
            otvaranje++;
            // Upiši novu vrijednost
            Application.Lock(); // Ključaj
            Application["otvaranje"] = otvaranje;
            Application.UnLock();

            // Nije greška ali ćemo iskoristiti labelu
            lb_greska.Text = otvaranje.ToString();

        }

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string kime = tb_kime.Text;
        string lozinka = tb_lozinka.Text;
        if (kime == "ivan" && lozinka == "ivan")
        {
            Session["korisnik"] = kime;
        } else
        {
            lb_greska.Text = "Ti nisi Ivan!!!";
        }

    }
    protected void Odjava_Click(object sender, EventArgs e)
    {
        // Booom
        throw new Exception("Puklooooooo!!!!!");
        // Uništi sesiju, trebalo bi provjeriti da li je uopće prijavljan
        Session.Abandon();

    }

}