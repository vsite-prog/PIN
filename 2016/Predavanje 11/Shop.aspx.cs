using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Shop : System.Web.UI.Page
{
    //Nek bude globalna da je vidimo u svim metodamaa
    Kosarica kosarica;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["kosara"] == null)
        { //Ništa nismo spremili kreiraj kosaru artikala ispočetaks
            kosarica = new Kosarica();
        } else
        {
            //već imamo nešto pa to sad osvježi
            kosarica = (Kosarica)Session["kosara"];
        }
        if (!IsPostBack) //Zašto Ispostback - da ne ponavljamo istu operaciju
        {
            prikazi();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        int id, kolicina;
        string naziv = tb_naziv.Text;
        decimal cijena;

        if (!Decimal.TryParse(tb_cijena.Text, out cijena)) return; //Trebalo bi staviti neku poruku o grešci
        if (!Int32.TryParse(tb_kolicina.Text, out kolicina)) return; //Trebalo bi i ovdje staviti neku poruku o grešci
        id = kosarica.DajKosaricu.Count + 1; //Vidi koliko ih ima u listi i dodaj za jedan
        //Kreiraj novi stavak narudžbe
        Stavak s = new Stavak();
        s.Id = id;
        s.Naziv = naziv;
        s.Cijena = cijena;
        s.Kolicina = kolicina;

        //Dodaj ga u košaricu
        kosarica.Dodaj(s);
        //Spremi je u Session
        Session["kosara"] = kosarica;
        //Prikaži podatke
        prikazi();
    }
    //Prikazujemo podatke u Gridu
    void prikazi()
    {
        //Prikaži košaricu
        gv_kupovina.DataSource = kosarica.DajKosaricu;
        gv_kupovina.DataBind();
    }

    protected void gv_kupovina_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //KAži koji red treba editirati, dobijete ga kao argument
        gv_kupovina.EditIndex = e.NewEditIndex;
    }

    protected void gv_kupovina_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        gv_kupovina.EditIndex = -1;
    }

    protected void gv_kupovina_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //Pročitaj novu vrijednost iz TBox-a i tu vrijednost upiši u košaricu
        //Prvo nađi red u kom se dešava promjena i referencu na textbox
        //Index je opet zadan kao argument
        GridViewRow row = gv_kupovina.Rows[e.RowIndex];
        //Nađi text box
        TextBox tb = (TextBox)row.Cells[3].Controls[0];
        //KOnačno evo količine
        int kolicina = Int32.Parse(tb.Text); //Ne bi bilo loše Try parse
        //upiši u Košaricu, indeks reda je i indeks u listi
        kosarica.Promijeni(e.RowIndex, kolicina);
        Session["kosara"] = kosarica;
        gv_kupovina.EditIndex = -1;
        prikazi();

    }

    protected void gv_kupovina_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Row command je generički događaj koji se okida gotovo uvijek
        if(e.CommandName == "dodaj")
        {
            //E sad dodaj +1 na količinu
            int rowNr = Convert.ToInt32(e.CommandArgument);
            //nađi postojeći red
            GridViewRow row = gv_kupovina.Rows[rowNr];
            //Pročitaj količinu
            int kolicina = Int32.Parse(row.Cells[3].Text);
            //SAd promijeni količinu
            //upiši u Košaricu, indeks reda je i indeks u listi
            kosarica.Promijeni(rowNr, ++kolicina);
            //refresh
            Session["kosara"] = kosarica;
            prikazi();
        }
    }
}