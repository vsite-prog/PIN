using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Entities db;
    protected void Page_Load(object sender, EventArgs e)
    {
        //database context
        db = new Entities();
        if (!IsPostBack) {
            populateDDL();
            showSki();
         }
    }

    protected void Unesi_Click(object sender, EventArgs e)
    {
        //Create new ski
        Ski skijaliste = new Ski();
        skijaliste.naziv = tb_naziv.Text;
        skijaliste.drzavaId = Int32.Parse(ddl_drzave.SelectedValue);
        //Add it to locasl collection
        db.Ski.Add(skijaliste);
        //Update database, generate SQL...
        db.SaveChanges();
        showSki();
    }

    private void populateDDL()
    {
        //Bind first DDL with table Drzava
        ddl_drzave.DataSource = db.Drzava.ToList<Drzava>();
        ddl_drzave.DataValueField = "id";
        ddl_drzave.DataTextField = "naziv";
        // Show  now the data
        ddl_drzave.DataBind();
    }

    private void showSki()
    {
        //Show database data
        //  gv_ski.DataSource = db.Ski.ToList<Ski>(); All ski elements
        //Get DrzavaId
        int _drzavaId = Int32.Parse(ddl_drzave.SelectedValue);
        //LINQ, not SQL
        var skijalista = from ski in db.Ski
                         where ski.drzavaId == _drzavaId
                         select new { ID=ski.id, Naziv = ski.naziv }; //ski;
        gv_ski.DataSource = skijalista.ToList();
        //Show  now the data
        gv_ski.DataBind();

      
    }

    protected void ddl_drzave_SelectedIndexChanged(object sender, EventArgs e)
    {
        showSki();
    }
}