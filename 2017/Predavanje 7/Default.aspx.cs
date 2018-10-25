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
        //Po koji put će ova stranica biti otvorena u našoj aplikaciji 
        //Ovo vrijedi za sve korisnike
        if (!IsPostBack) //ne zanimaju na s postback-ovi
        {
            int otvaranje = 1;
            Application.Lock();
            if (Application["otvaranje"] != null)
            {
                otvaranje = (int)Application["otvaranje"] + 1;
            }
            Application["otvaranje"] = otvaranje;
            Application.UnLock();
            lb_otvaranje.Text = otvaranje.ToString() + ". otvaranje po redu!";
        }

        
        
        // Ovdje bi trebalo vidjeti koji dio se prikazuje login ili logout
        showLogin();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
       // throw new Exception("kaboooom!!!!");
        //Vidi ima li hardcode-iranog korisnika
        if (AllUsers.Find(tb_uname.Text, tb_psw.Text))
        {
            Session["user"] = tb_uname.Text;
            showLogin();

        } else
        {
            lb_greska.Text = "Neuspjela prijava";
        }

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //Sesija se može i ručno prekinuti
        Session.Abandon();
        showLogin();

    }

    void showLogin()
    {
        //Ako je prijavljen pokaži odjavu a ako ne prijavu
        if (Session["user"] != null)
        {
            lb_user.Text = "KOrisničko ime: " + Session["user"].ToString();
            pn_login.Visible = false;
            pn_logout.Visible = true;
        } else
        {
            pn_login.Visible = true;
            pn_logout.Visible = false;
        }
    }
}