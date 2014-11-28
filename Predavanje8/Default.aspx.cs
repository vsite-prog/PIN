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

    }
    protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        //Događaj koji će GV okinuti na pritisak Odaberi

        GridView gv = gv_zivotinje; //Intelisense budi se
        GridViewRow row = gv.SelectedRow;

        //Pročitaj tekst iz ćelija trenutnog reda
        Label1.Text = "Selektirali ste: " + row.Cells[1].Text + " vrste: " + row.Cells[2].Text;
    }
}