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

        //Event on click on select in different row
        string naziv, vrsta;
        GridView gv = GridView1; // GridView Object!
        GridViewRow row = gv.SelectedRow; //Row in which select has been clicked
        naziv = row.Cells[1].Text; //Read from cells in gridview
        vrsta = row.Cells[2].Text;

        lb1.Text = "Tree values in this row are: "  + naziv + ": "  + vrsta;
    }
}