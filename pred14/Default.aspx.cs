using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Prikaži na stranici u labeli lb_vrijeme, vrijeme zadnjeg otvaranja stranice od bilo kog user-a 
    //Ako jer ovo prvo otvaranje napiši Stranica nije prije otvarana
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Application["vrijeme"] == null)
        {
            lb_vrijeme.Text = "Stranica nije prije otvarana";
            lb_vrijeme.ForeColor = System.Drawing.Color.Red;
        }
        else
        {
            //pazi nas kast u odgagvarajući tip
            lb_vrijeme.Text = (string) Application["vrijeme"];
            lb_vrijeme.ForeColor = System.Drawing.Color.Black;
        }

        Application["vrijeme"] = DateTime.Now.ToString();



    }
}