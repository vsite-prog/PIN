using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    Kosarica kosarica;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Kreiraj košaricu ako ne postoji
        if  (Session["kosarica"] == null)
        {
            //Kreiraj novu kosaricu
            kosarica = new Kosarica();
        }
        else
        {
            kosarica = (Kosarica)Session["kosarica"];
        }
        prikaziKosaricu();

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        int kolicina;
        decimal cijena;

        //provjeri količinu
        if (!Int32.TryParse(tb_kolicina.Text, out kolicina))
        {
            lb_greska.Text = "Kriva količina";
            return;
        }

        //provjeri cijenu
        if (!Decimal.TryParse(tb_cijena.Text, out cijena))
        {
            lb_greska.Text = "Kriva cijena";
            return;
        }
        //Kreiraj novi element liste
        Stavak stavak = new Stavak(kosarica.dajId(),tb_naziv.Text, cijena, kolicina);
        kosarica.Dodaj(stavak);

        //Spremi za idući put
        Session["kosarica"] = kosarica;

        //Refresh
        prikaziKosaricu();

    }

    private void prikaziKosaricu()
    {
        //Postavi izvor podataka
        gv_kosarica.DataSource = kosarica.DajKosaricu;
        // Refresh
        gv_kosarica.DataBind();
    }

    protected void gv_kosarica_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //Prebaci u edit mod
        gv_kosarica.EditIndex = e.NewEditIndex;
        prikaziKosaricu();
    }
    protected void gv_kosarica_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //Nitko se ne editira
        gv_kosarica.EditIndex = -1;
        prikaziKosaricu();
    }
    protected void gv_kosarica_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //Promijeni rekord u košarici
        GridViewRow row = gv_kosarica.Rows[e.RowIndex];
        //Dohvati u našem redu četvrtu ćeliju i unutar nje textbox kontrolu
        TextBox kbox = (TextBox)row.Cells[3].Controls[0];
        int kolicina = Int32.Parse(kbox.Text);
        kosarica.Promijeni(e.RowIndex, kolicina);
        //Nitko se ne editira
        gv_kosarica.EditIndex = -1;
        //Refresh
        prikaziKosaricu();


    }
    protected void gv_kosarica_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        //Svi ga okidaju
        if (e.CommandName == "Uvecaj")
        {
            //dohvatoi index
            int index = Convert.ToInt32(e.CommandArgument);
            //Dohvati red
            GridViewRow row = gv_kosarica.Rows[index];
            //dohvati količinu iz gv-a
            int kolicina = Int32.Parse(row.Cells[3].Text);
            kosarica.Promijeni(index, ++kolicina);
            //refresh
            prikaziKosaricu();
        }
    }
}