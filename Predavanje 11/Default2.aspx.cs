using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    Kosarica basket; //HR - ENG mix
    protected void Page_Load(object sender, EventArgs e)
    {


        if (Session["basket"] == null)
        {
            basket = new Kosarica();
        } else
        {
            basket = (Kosarica)Session["basket"];
        }

        if (!IsPostBack) //Show basket in GV
            showBasket();
    }

    protected void lb_spremi_Click(object sender, EventArgs e)
    {
        string naziv = tb_naziv.Text;
        int kolicina;
        decimal cijena;
        if(!Int32.TryParse(tb_kolicina.Text, out kolicina)) //check if it is int number
        {
            lb_greska.Text = "Nije količina dobra.."; //Error message
            return;
        }

        if (!Decimal.TryParse(tb_cijena.Text, out cijena)) //check if it is int number
        {
            lb_greska.Text = "Nije cijena dobra.."; //Error message
            return;
        }

        Stavak stavak = new Stavak(basket.NoviId(),naziv, cijena, kolicina);
        basket.Dodaj(stavak); //add to basket

        Session["basket"] = basket; //Save to session
        showBasket();
    }

    public void showBasket()
    {
        gv_kupovina.DataSource = basket.DajKosaricu; //take list and show it in GV
        gv_kupovina.DataBind();

    }

    protected void gv_kupovina_RowEditing(object sender, GridViewEditEventArgs e)
    {
        gv_kupovina.EditIndex = e.NewEditIndex; //Edit clicked row
        showBasket();
    }

    protected void gv_kupovina_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow row = gv_kupovina.Rows[e.RowIndex]; //Get current row
       // int id = Int32.Parse(row.Cells[0].Text); //REad text from cell
        TextBox tbkol = (TextBox)row.Cells[2].Controls[0]; //take first controll it is tbox
        int kolicina = Int32.Parse(tbkol.Text);
        //Now updata basket
        basket.Promijeni(e.RowIndex, kolicina);
        gv_kupovina.EditIndex = -1; //Edit done
        showBasket();
    }

    protected void gv_kupovina_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gv_kupovina.EditIndex = -1;
        //Refresh
        showBasket();
    }

    protected void gv_kupovina_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        //Delete from list & refresh
        basket.Brisi(e.RowIndex);
        showBasket();
    }

    protected void gv_kupovina_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //All commands are here 
        if (e.CommandName == "plusplus")
        {
            int rowid = Convert.ToInt32(e.CommandArgument); //is this row num?
            GridViewRow row = gv_kupovina.Rows[rowid];
            int id = Int32.Parse(row.Cells[0].Text);
            basket.Dodaj(id,null,0);
            showBasket();
        }
    }
}