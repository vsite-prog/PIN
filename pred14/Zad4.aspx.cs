using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Zad4 : System.Web.UI.Page
{
    //Nakon prijave korisnika vidjeti da li su kime i lozinka isti ako jesu proslijedi g ana stranicu cdfdas
    //Lozinka je hashirana i spremljena sa solju
    string kime = "";
    string spremljenaLozinka = "fvdsgfdsgadsvdsf";
    string salt = "fhcfh";
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //hashiraj je zadana funkcija 
        string lozinka = tb_lozinka.Text;
        string hashLoz = hashiraj(lozinka);
        string slanaHashLozinka = hashiraj(salt + hashLoz);
        if (tb_ime == kime && slanaHashLozinka == spremljenaLozinka)
        {
            Response.Redirect("dxasda.aspx");
        }
        else
        {
            lb_nemame.Text = "Krivooo";
        }




    }
}