using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //Ovo je objekt koji predstavlja našu bazu
    Entities db = new Entities();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //Daj listu vlasnika
            ddl_vlasnici.DataSource = db.Vlasnik.ToList<Vlasnik>();
            //Pokaži tekst i value iz tablice
            ddl_vlasnici.DataValueField = "id";
            ddl_vlasnici.DataTextField = "ime";
            //Refreshaj podatke
            ddl_vlasnici.DataBind();
        }

        //Koji je trenutni vlasnik
        int id = Int32.Parse(ddl_vlasnici.SelectedValue);
        //Napuni GView pomoću LINQ-a
        var psi = from pas in db.Pas //za svakog psa
                  where pas.vlasnikId == id //vidi da li mu je vlasnik selektiran 
                  select new { ID = pas.id, IME = pas.ime };
        //Refresh
        GridView1.DataSource = psi.ToList();
        GridView1.DataBind();

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Kreiraj novog psa u bazi
        Pas pas = new Pas();
        //Unesi mu podatke
        pas.ime = tb_ime.Text;
        pas.vlasnikId = Int32.Parse(ddl_vlasnici.SelectedValue);
        //Dodaj ga u listu
        db.Pas.Add(pas);
        //Spremi u bazu
        db.SaveChanges();
    }
}