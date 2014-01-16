using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ZivotinjeModel;

public partial class _Default : System.Web.UI.Page
{
    DatabaseEntities db; //neka bude global za klasu
    protected void Page_Load(object sender, EventArgs e)
    {
        db = new DatabaseEntities();
        /*
        //Kreiraj kontekst baze
        DatabaseEntities db = new DatabaseEntities();
        // Daj mi sve životinje iz baze u obliku liste da mogu biti izvor podataka za GV
        List<zivotinja> lista_zivotinja = db.zivotinja.ToList<zivotinja>();

        //postavi listu kao izvor za GV
        gv_zivotinje.DataSource = lista_zivotinja;
        //Učitaj podatke u GV
        gv_zivotinje.DataBind();
        */

        if (!IsPostBack)
        {
            //definiraj polje koje će se prikazati na stranici
            ddl_zoo.DataTextField = "grad";
            //Definiraj polje koje će sadržavati vrijednost izbora
            ddl_zoo.DataValueField = "id";
            List<zoo> lista_zoo = db.zoo.ToList<zoo>();
            //lista kao izvor podataka
            ddl_zoo.DataSource = lista_zoo;
            //osvleži podatke
            ddl_zoo.DataBind();

            postavi_grid();
        }



    }

    private void postavi_grid()
    {
        //Pročitaj odabir iz DDL-a i prebaci u int
        int zoo_id = Int32.Parse( ddl_zoo.SelectedValue);

        //Idemo LINQ, sve životinje iz tog ZOO-a
        var lista_zivotinja = from z in db.zivotinja //prođi rekord po rekor kroz tablicu
                              where z.zooId == zoo_id //obrati ==
                              select new
                              { //kreiraj novi objekt i dodaj ga u listu
                                  Ime = z.ime, //property
                                  Vrsta = z.vrsta
                              };
        //postavi listu kao izvor za GV
        gv_zivotinje.DataSource = lista_zivotinja;
        //Učitaj podatke u GV
        gv_zivotinje.DataBind();

    }
    protected void ddl_zoo_SelectedIndexChanged(object sender, EventArgs e)
    {
        //pokaži životinje iz odabranog zoo-a
        postavi_grid();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        //kreiraj novi objekt životinja
        zivotinja z = new zivotinja();
        //POstavo property iz TB-a
        z.ime = tb_ime.Text;
        z.vrsta = tb_vrsta.Text;
        //uzmi iz DDL vrijednost ZOO-a
        z.zooId = Int32.Parse(ddl_zoo.SelectedValue);
        //dodaj u memoriji servera novi objekt u životinje
        db.AddObject("zivotinja", z);
        //preko ADO.NET-a spremi u Bazu
        db.SaveChanges();
        postavi_grid();
    }
}