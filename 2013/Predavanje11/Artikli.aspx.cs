using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Artikli : System.Web.UI.Page
{
    Kosarica ks;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["korpa"] == null)
            //Kreiraj kosaricu ako je nema
            ks = new Kosarica();
        else
            //Pokupi kupljene art. iz session
            ks = (Kosarica)Session["korpa"];

        //prvo ottvaranje stranice
        if (!IsPostBack)
            povezi();
    }

     protected void bt_artikl_Click(object sender, EventArgs e)
    {
        //Jreiraj novi artikkl sa vrijednostima dodanima unutar tbox-ova
        Stavak s = new Stavak();
        s.Id = Int32.Parse( tb_id.Text);
        s.Naziv = tb_naziv.Text;
        s.Cijena = Decimal.Parse(tb_cijena.Text);

        //Dodaj novi stavak u listu kupljenih artikala

        ks.Dodaj(s);

         // prikazi GV podatke
        povezi();
    }

     protected void povezi()
     {
         //Spremi u SessionState
         Session["korpa"] = ks;
         // POveži sa gridview-om
         gv_artikli.DataSource = ks.DajKosaricu;
         //
         gv_artikli.DataBind();
     }
     protected void gv_artikli_RowEditing(object sender, GridViewEditEventArgs e)
     {
         //KOji red treba prebaciti u edit mode
         gv_artikli.EditIndex = e.NewEditIndex;
         povezi();
     }
     protected void gv_artikli_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
     {
         //Niti jedan red se ne editira
         gv_artikli.EditIndex = -1;
         povezi();

     }
     protected void gv_artikli_RowUpdating(object sender, GridViewUpdateEventArgs e)
     {
         // Dohvati red u GV i ćeliju količine (3. po redu) unutra se nalazi TBox - dohvati ga iz kolekcije kontrola
         TextBox tb = (TextBox)gv_artikli.Rows[e.RowIndex].Cells[3].Controls[0];
         //Dohvati novu količinu 
         int kolicina = Int32.Parse( tb.Text);
         //Promijeni u košarici
         ks.Promijeni(e.RowIndex, kolicina);

         //Van iz edit moda
         gv_artikli.EditIndex = -1;
         //Prikaži u gridu
         povezi();

        
     }

     protected void gv_artikli_RowCommand(object sender, GridViewCommandEventArgs e)
     {
         if (e.CommandName == "Dodaj")
         {
             //Želimo  broj reda , dobiti ćemo ga iz ulaznih podataka i prebaciti u int - Convert
             int index = Convert.ToInt32(e.CommandArgument);
             //Pročitaj količinu iz reda koji treba i ćelije koja ima količinu
             int kolicina = Int32.Parse( gv_artikli.Rows[index].Cells[3].Text);
             //Promijeni u listi košarice 
             ks.Promijeni(index, kolicina + 1);
             //Prikaži u gridu
             povezi();

         }
     }
     protected void gv_artikli_RowDeleting(object sender, GridViewDeleteEventArgs e)
     {
         //Briši element iz liste
         ks.Brisi(e.RowIndex);
         //Prikaži 
         povezi();
     }
}