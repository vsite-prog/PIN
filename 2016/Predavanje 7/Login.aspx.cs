using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            lb_greska.Text = "";
        }
        int otvaranje = 0; //KOje je ovo otvaranje ove stranice, bilo postback ili ne od bilo kojeg usera
        if(Application["otvaranje"] != null)
        {
            otvaranje = (int)Application["otvaranje"];
        }
        otvaranje++; //zabilježi sadašnje otvaranje i piši u labelu
        lb_otvaranje.Text = "Otvaranje po: " + otvaranje.ToString() + ". put";

        //zaključaj i upiši
        Application.Lock();
        Application["otvaranje"] = otvaranje;
        Application.UnLock();

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        User user = Global.UserExists(tb_uname.Text, tb_psw.Text);
        if ( user != null)
        {
            //login uspio idemo dalje
            //U SS spremi cijeli objekt korisnika
            Session["user"] = user;
            Response.Redirect("Default.aspx");
        } else
        {
            lb_greska.Text = "Krivi login";
        }
        //Spremi usera u sessionstate
        // promijenjeno: Session["user"] = tb_uname.Text;
        // Ovo je postback neće raditi Response.Redirect(Request.UrlReferrer.ToString());
        
    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //Booom
        throw new Exception("Hasta la vista! BOooooooooooooom...");
    }
}