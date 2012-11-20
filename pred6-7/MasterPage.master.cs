using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kime"] != null) ;
 

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Korisnik kor = ListaKorisnika.nadjiKorisnika(tb_kime.Text,tb_lozinka.Text );

        if (kor != null)
            Session["kime"] = tb_kime.Text;
        // to be continued...
  

    }
}
