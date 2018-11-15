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
        if (!IsPostBack)
        {
            // Viewstate je prazan, idemo kreirati naš brojač
            ViewState["brojac"] = 0;
        }
        else
        {
            // Pročitaj brojač i uvećaj za 1
            int brojac = (int)ViewState["brojac"];
            brojac++;
            //Sada zapamti brojač
            ViewState["brojac"] = brojac;
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Nije baš optimalno ali vidimo kako radi
        Label1.Text += "Kliknuli smo po: " + ViewState["brojac"].ToString() + ". put!<br>";
    }
}