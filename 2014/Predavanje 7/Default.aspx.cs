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
        int cnt = 1;

        if (!IsPostBack)
        {
            if (Application["counter"] != null)
            {
                //Čitanje iz App state
                cnt = (int)Application["counter"];
                cnt++;
            }

            //Pisanje u App state 
            Application["counter"] = cnt;
            //Pokaži na labeli
            lb_broj.Text = "Stranica otvorena: " + cnt.ToString() + ".put";
        }
    }
    protected void bt_greska_Click(object sender, EventArgs e)
    {
        //baci grešku za global
       // throw new Exception("Puklo je, boooom...");

        //zajednička konstanta
        lb_tajna.Text = Global.tajna;
    }
}