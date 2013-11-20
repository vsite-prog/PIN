using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int nula = 0;
        int brojac = 1;
        nula = brojac / nula; //Exception

        if (Application["zahtjevDef2"] == null)
        {
            Application["zahtjevDef2"] = brojac;
        }
        else
        {
            brojac = (int)Application["zahtjevDef2"] + 1;
            Application["zahtjevDef2"] = brojac;
        }
        Label1.Text += brojac.ToString();
    }
}