using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Kupovina : System.Web.UI.Page
{
    Kosarica kupovina;
    protected void Page_Load(object sender, EventArgs e)
    {
        //Zapamti našu kupovinu između postback-ova
        if (Session["kupovina"] == null)
            kupovina = new Kosarica();
        else
            kupovina = (Kosarica) Session["kupovina"];

        if (!Page.IsPostBack)
            poveziPodatke(); //Refresh-aj našu košaricu i pokaži nam podatke

    }
    protected void bt_knjiga_Click(object sender, EventArgs e)
    {
        //Pročitaj količinu iz textboxa
        int kol = Convert.ToInt32(tb_kolicina.Text);
        //Kreiraj novi stavak tipa knjge sa tom količinom, M je Money decimal konstanta
        Stavak st = new Stavak(1, "Naša knjiga", 304.23M, kol);
        kupovina.Dodaj(st);
        //Zapamti promjene u Session
        poveziPodatke();


    }
    protected void br_cd_Click(object sender, EventArgs e)
    {
        //Pročitaj količinu iz textboxa
        int kol = Convert.ToInt32(tb_kolicina.Text);
        //Kreiraj novi stavak tipa knjge sa tom količinom, M je Money decimal konstanta
        Stavak st = new Stavak(2,"Naš CD", 124.78M, kol);
        kupovina.Dodaj(st);
        //Zapamti promjene u Session

        poveziPodatke();

    }
    protected void gv_kupovina_RowCommand(object sender, GridViewCommandEventArgs e)
    {
        string komanda = e.CommandName;
        if (komanda == "Dodaj"){
            //Nađi iz ulaznih argtumenata dobiti ćemo index reda
            int index = Convert.ToInt32(e.CommandArgument);
            //za taj red dohvati vrijednost ćelije
            int id = Convert.ToInt32(gv_kupovina.Rows[index].Cells[0].Text);
            //kreiraj novi stavak sa kol 1 - ostalo nije ni bitno 
            Stavak st = new Stavak(id, "Naša knjiga", 123M, 1);
            //Dodaj ga u listu i prikaži
            kupovina.Dodaj(st);
            poveziPodatke();



        }
        //

    }
    protected void gv_kupovina_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int index = e.RowIndex;
        kupovina.Brisi(index);
        poveziPodatke();
    }

    private void poveziPodatke()
    {
        Session["kupovina"] = kupovina;
        gv_kupovina.DataSource = kupovina.DajKosaricu;
        gv_kupovina.DataBind();
    }


    protected void gv_kupovina_RowEditing(object sender, GridViewEditEventArgs e)
    {
        //okida se kad počnemo editiranje 
        //Kažemo koji red editiramo 
        gv_kupovina.EditIndex = e.NewEditIndex;
        //refresh
        poveziPodatke();
    }
    protected void gv_kupovina_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        //stavi index reda koji se editira na nepostojeći, van iz edit moda
        gv_kupovina.EditIndex = -1;
        poveziPodatke();
    }
    protected void gv_kupovina_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        //Dohvati red koji se mijenja, argumenti pokazuju o kom redu je riječ
        GridViewRow red = (GridViewRow) gv_kupovina.Rows[e.RowIndex];
        //Dohvati ćeliju unutar reda koja sadrži tbox
        DataControlFieldCell celija = (DataControlFieldCell)red.Controls[3];
        //tbox je prva kontrola unutar ćelije, pročitaj ga 
        TextBox tb = (TextBox)celija.Controls[0];
        int kol = Int32.Parse( tb.Text);

        if (kol > 0)
            kupovina.Promijeni(e.RowIndex, kol);
        else
            e.Cancel = true; //nije nam potrebno alli evo kako se može zaustaviti daljnje procesiranje

        //van iz edit moda...
        gv_kupovina.EditIndex = -1;
        poveziPodatke();

        





    }
}